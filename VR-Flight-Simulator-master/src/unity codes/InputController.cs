using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Net.Sockets;
using System.IO;
using System.Text;
using System.Threading;

public class InputController : MonoBehaviour
{
    public float gyro=0;
    public float ultrasonic = 0;
    public float bump = 0;
    public float pot = 0;
    public bool StateClient;

    public void Begin(string ipAddress, int port)
    {
        //Give the network stuff its own special thread
        var thread = new Thread(() =>
        {
            //This class makes it super easy to do network stuff
            var client = new TcpClient();

            //Change this to your real device address
            client.Connect(ipAddress, port);

            var stream = new StreamReader(client.GetStream());

            //We'll read values and buffer them up in here
            var buffer = new List<byte>();

            StateClient = client.Connected;

            while (client.Connected)
            {
                //Read the next byte
                var read = stream.Read();

                //We split readings with a carriage return, so check for it
                if (read == 13)
                {
                    //Once we have a reading, convert our buffer to a string, since the values are comming as strings
                    var str = Encoding.ASCII.GetString(buffer.ToArray());
                    string[] split = str.Split(new char[] { ' ' });
                    float[] val = new float[4];

                    val[0] = float.Parse(split[0]);
                    val[1] = float.Parse(split[1]);
                    val[2] = float.Parse(split[2]);
                    val[3] = float.Parse(split[3]);
                    gyro = val[0];
                    ultrasonic = val[1];
                    bump = val[2];
                    pot = val[3];
                    //Clear the buffer ready for another reading
                    buffer.Clear();
                }
                else
                    //if this was not the end of a reading, then just add this new byte to our buffer
                    buffer.Add((byte)read);
            }
        });

        thread.Start();
    }
}

