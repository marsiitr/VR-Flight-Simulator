# VR-Flight-Simulator
Srishti 2019

### PROJECT
<img src="https://github.com/Nikhil-Choudhary/VR-Flight-Simulator/blob/master/Photos%20And%20Videos/photos/Game.jpeg" width="100%" height="100%">

## ABSTRACT

The project we made is known as VR Flight Simulator.It is a simulation of real life plane experience.
In this project We had used a ultrasonic sensor, a bump sensor, a potentiometer sensor, a gyroscope
sensor (esp8266), and a esp9250 module to make a joystick and a throttle handle. The joytick physically
moved in vertical circular motion in left write direction, and it moved front and backwards producing 
respective motion in game. The throttles went front and backwards to accelerate and decelerate the plane
respectively.A game on pc was developed by us which contains a plane and some objects which can be shot.

## MOTIVATION

Our motivation for doing this project was the creativity of the idea and our fascination with the end result.

## MECHANICAL ASPECT OF DESIGN

 Mechanical Design
 <img src="https://github.com/Nikhil-Choudhary/VR-Flight-Simulator/blob/master/Photos%20And%20Videos/photos/Project%20Mechanical%20design.jpeg" width="100%" height="80%">
 
  Plane Mesh Made From Wire
 <img src="https://github.com/Nikhil-Choudhary/VR-Flight-Simulator/blob/master/Photos%20And%20Videos/photos/plane.jpeg" width="100%" height="80%">
 
Our mechanical parts consists of:
	
 1. **Joystick**	-This device is used for controlling the aeroplane so that user experiences reality ( gives us a real experience ), with the help of this device we tried to make environment like that of aeroplane .
2. **Throttle** 	-This device is basically used for controling the speed of aeroplane.

Both the devices are made from basic components such as ply , a man made springs , steel channels , ball bearings , and joining components

## ELECTRONIC ASPECT OF DESIGN

Electronics Consist of use of:

1. **Ultrasonic sensor**	-for giving pitch to plane
2. **Gyro sensor**	-for detecting right-left motion of plane
3. **Potentiometer**	-for detecting throttle
4. **Bump Sensor**	-for detecting Rocket shooting
5. **Esp module**	-for receiving data from sensors and sending it to unity	

## WORKING

 While Playing
<img src="https://github.com/Nikhil-Choudhary/VR-Flight-Simulator/blob/master/Photos%20And%20Videos/photos/while%20playing.jpeg" width="100%" height="80%">

* Taking input from 4 sensors(in form of nos.) and sending this input to unity software through esp module
* After receiving data we are scaling it in unity to make it in suitable form and sending it to our game
* Then we are using a software called trinus vr to project computer screen onto our mobile in form of 3d environment by making pc as server and mobile as receiver
* This is it. Syncing sensor input and input in unity was very crucial.
 
## COST STRUCTURE

1. **Mechanical** 

	|  Component |Cost(INR) |
	|-------------|-------|
	|   Welding   |   70  |
	|     Ply (Wood)     |   300 |
	|     Wire    |  200  |
	|  Esp8266 module   |  500  |
	| Ultrasonic sensor |  100  |
	|    Bump sensor    |  20   |
	|  Potentiometer    |  50   |
	|   Total|1240|

## APPLICATIONS

1. It can used for real life pilot training. 
2. It can also be used as a game for mass selling. 

## LIMITATIONS

1. There was a slight noticable delay in rotation of joystick and its effect on screen, due to a long method of transmission of signal.
2. The system also failed at the end of shrishti so its durablity can be improved.

## FUTURE IMPROVMENTS

1. The delay of joystick rotation to its result can be decreased by using a short way of giving a signal to software and also optimizing the graphics in simulation.
2. Some software improvments can be done such as adding of distance from mountain (or building) in front, or if the plane is losing stability then how to control it and also maintaining a scorecard and highscore board .

## TEAM MEMBERS

1. Allu Vamsi Vishal
2. Himanshu Akodiya 
3. Nikhil Choudhary
4. Shashwat Vangani

## MENTORS

1. Dhruv Sehgal
2. Gautam Jha

## REFRENCES

1. [Getting Started With the ESP8266 ESP-01](www.instructables.com/id/Getting-Started-With-the-ESP8266-ESP-01/https://www.instructables.com/id/Getting-Started-With-the-ESP8266-ESP-01/)

	`www.instructables.com/id/Getting-Started-With-the-ESP8266-ESP-01/https://www.instructables.com/id/Getting-Started-With-the-ESP8266-ESP-01`

2. [Wiring ESP8266 nodeMCU with HCSR04 Ultrasonic Sensor](https://www.14core.com/wiring-esp8266-nodemcu-with-hcsr04-ultrasonic-sensor/)

	`https://www.14core.com/wiring-esp8266-nodemcu-with-hcsr04-ultrasonic-sensor`

3. [How to use a potentiometer to control the speed of a DC Motor](www.youtube.com/watch?v=S-AMqJW0Cvohttps://www.youtube.com/watch?v=S-AMqJW0Cvo)

	`www.youtube.com/watch?v=S-AMqJW0Cvohttps://www.youtube.com/watch?v=S-AMqJW0Cvo`

4. [Programming using a bump sensor (really basic/beginner)](forum.arduino.cc/index.php?topic=59742.0https://forum.arduino.cc/index.php?topic=59742.0)

	`forum.arduino.cc/index.php?topic=59742.0https://forum.arduino.cc/index.php?topic=59742.0`

5. [How to use MPU-9250 Gyroscope, Accelerometer, Magnetometer](www.youtube.com/watch?v=mzwovYcozvIhttps://www.youtube.com/watch)

	`www.youtube.com/watch?v=mzwovYcozvIhttps://www.youtube.com/watch?v=mzwovYcozvI`

6. [SolidWorks Tutorial](www.youtube.com/channel/UCtwaWPOXEBysZLh1rrPzwFwhttps://www.youtube.com/channel/UCtwaWPOXEBysZLh1rrPzwFw)

	`www.youtube.com/channel/UCtwaWPOXEBysZLh1rrPzwFwhttps://www.youtube.com/channel/UCtwaWPOXEBysZLh1rrPzwFw`

7. [Unity Tutorials](https://www.youtube.com/user/Unity3D/videos)

	`https://www.youtube.com/user/Unity3D/videos`
	
***

