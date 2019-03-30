using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Rocket : MonoBehaviour
{
    public Text scoreText;
   
    // The fly speed (used by the weapon later)
    public float speed = 2000.0f;
 
  
    // explosion prefab (particles)
    public GameObject explosionPrefab;
    

    // find out when it hit something
   


        void OnCollisionEnter(Collision c)
        {
       
           
            // show an explosion
            // - transform.position because it should be
            //   where the rocket is
            // - Quaternion.identity because it should
            //   have the default rotation
            Instantiate(explosionPrefab, transform.position, Quaternion.identity);
            if (c.gameObject.name == "Cube" || c.gameObject.name == "Cube (1)" || c.gameObject.name == "Cube (2)" || c.gameObject.name == "Cube (3)" || c.gameObject.name == "Cube (5)" || c.gameObject.name == "Cube (6)" || c.gameObject.name == "Cube (7)" || c.gameObject.name == "Cube (8)" || c.gameObject.name == "Cube (9)" || c.gameObject.name == "Cube (10)" || c.gameObject.name == "Cube (11)" || c.gameObject.name == "Cube (12)" || c.gameObject.name == "Cube (13)" || c.gameObject.name == "Cube (14)" || c.gameObject.name == "Cube (15)" || c.gameObject.name == "Cube (16)" || c.gameObject.name == "Cube (17)" || c.gameObject.name == "Cube (18)" || c.gameObject.name == "Cube (19)" || c.gameObject.name == "Cube (20)" || c.gameObject.name == "Cube (21)" || c.gameObject.name == "Cube (22)" || c.gameObject.name == "Cube (23)" || c.gameObject.name == "Cube (24)" || c.gameObject.name == "Cube(25)" || c.gameObject.name == "Cube (26)" || c.gameObject.name == "Cube (27)" || c.gameObject.name == "Cube (28)" || c.gameObject.name == "Cube (29)" || c.gameObject.name == "Cube (30)" || c.gameObject.name == "Cube (31)" || c.gameObject.name == "Cube (32)" || c.gameObject.name == "Cube (33)" || c.gameObject.name == "Cube (34)" || c.gameObject.name == "Cube (35)" || c.gameObject.name == "Cube (36)" || c.gameObject.name == "Cube (37)" || c.gameObject.name == "Cube (38)" || c.gameObject.name == "Cube (39)" || c.gameObject.name == "Cube (40)" || c.gameObject.name == "Cube (41)" || c.gameObject.name == "Cube (42)" || c.gameObject.name == "Cube (43)" || c.gameObject.name == "Cube (44)" || c.gameObject.name == "Cube (45)" || c.gameObject.name == "Cube (46)" || c.gameObject.name == "Cube (47)" || c.gameObject.name == "Cube (48)" || c.gameObject.name == "Cube (49)" || c.gameObject.name == "Cube (50)" || c.gameObject.name == "Cube (51)" || c.gameObject.name == "Cube (52)" || c.gameObject.name == "Cube (53)" || c.gameObject.name == "Cube (54)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (55)" || c.gameObject.name == "Cube (56)" || c.gameObject.name == "Cube (57)" || c.gameObject.name == "Cube (58)" || c.gameObject.name == "Cube (59)" || c.gameObject.name == "Cube (60)" || c.gameObject.name == "Cube (61)" || c.gameObject.name == "Cube (62)" || c.gameObject.name == "Cube (63)" || c.gameObject.name == "Cube (64)" || c.gameObject.name == "Cube (65)" || c.gameObject.name == "Cube (66)" || c.gameObject.name == "Cube (67)" || c.gameObject.name == "Cube (68)" || c.gameObject.name == "Cube (69)" || c.gameObject.name == "Cube (70)" || c.gameObject.name == "Cube (71)" || c.gameObject.name == "Cube (72)" || c.gameObject.name == "Cube (73)" || c.gameObject.name == "Cube (74)" || c.gameObject.name == "Cube (77)" || c.gameObject.name == "Cube (76)" || c.gameObject.name == "Cube (77)" || c.gameObject.name == "Cube (78)" || c.gameObject.name == "Cube (79)" || c.gameObject.name == "Cube (80)" || c.gameObject.name == "Cube (81)")
        {
            Destroy(c.gameObject);
            // string rid = System.IO.File.ReadAllText(@"C:\Users\Public\TestFolder\rocketid.txt");
            string text = System.IO.File.ReadAllText(@"D:\unity\vr flight simulator\vr flight simulator\rocket.txt");
            int w = int.Parse(text);
            int w2 = 1 + w;
            string[] lines = { w2.ToString() };
            System.IO.File.WriteAllLines(@"D:\unity\vr flight simulator\vr flight simulator\rocket.txt", lines);
            /*string text2 = System.IO.File.ReadAllText(@"D:\unity\vr flight simulator\vr flight simulator\rocket.txt");
            int w3 = int.Parse(text2);
            Debug.Log(text2);*/
            scoreText.text = w2.ToString();
           
            

            }

        

            // destroy the rocket
            // note:
            //  Destroy(this) would just destroy the rocket
            //                script attached to it
            //  Destroy(gameObject) destroys the whole thing
            Destroy(gameObject);
        

    }
    
}
