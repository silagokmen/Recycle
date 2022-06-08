
using System.Collections;
using System.Collections.Generic;
using UnityEngine;




public class Drag : MonoBehaviour
{
    private Vector3 offset;
    
    private float mZCoord;

    public static bool isOkay;
    public static bool isWrong;
    public static bool isSad;

    private void Start()
    {
       
        isOkay = false;
       
    }





    private void Update()
    {
        transform.Translate(Vector3.left* 7 * Time.deltaTime);


        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit, 100))
            {
                if (hit.collider.tag == "Poop")
                {
                    isSad = true;
                    RandomText.cc = false;
                    
                    
                   
                }
            }

        }


        if (transform.position.x <= -53.0f)
        {
            Destroy(gameObject);
        }

    }




    void OnMouseDown()
    {
        mZCoord = Camera.main.WorldToScreenPoint(gameObject.transform.position).z;
        offset = gameObject.transform.position - GetMouseWorldPos();

    }

    private Vector3 GetMouseWorldPos()
    {
        Vector3 mousePoint = Input.mousePosition;
        mousePoint.z = mZCoord;
        return Camera.main.ScreenToWorldPoint(mousePoint);
    }

     void OnMouseDrag()
    {
        transform.position = GetMouseWorldPos() + offset;
        
    }

    

    private void OnTriggerEnter(Collider other)
    {


        if (other.CompareTag("CamKutu") == CompareTag("Cam"))
        {
            Destroy(this.gameObject);
            isOkay = true;
            RandomText.aa = false;
            RandomText.score += 5;
        }
        if(other.CompareTag("CamKutu") != CompareTag("Cam"))
        {
            Destroy(this.gameObject);
            isOkay = false;
            isWrong = true;
            RandomText.bb = false;

        }






        if (other.CompareTag("KagıtKutu") == CompareTag("Kagıt"))
        {
            Destroy(this.gameObject);
            isOkay = true;
            RandomText.aa = false;
            RandomText.score += 5;
        }
        if (other.CompareTag("KagıtKutu") != CompareTag("Kagıt"))
        {
            Destroy(this.gameObject);
            isOkay = false;
            isWrong = true;
            RandomText.bb = false;
        
        }








        if (other.CompareTag("MetalKutu") == CompareTag("Metal"))
        {
            Destroy(this.gameObject);
            isOkay = true;
            RandomText.aa = false;
            RandomText.score += 5;

        }
        if (other.CompareTag("MetalKutu") != CompareTag("Metal"))
        {
            Destroy(this.gameObject);
            isOkay = false;
            isWrong = true;
            RandomText.bb = false;
           
        }








        if (other.CompareTag("PlastikKutu") == CompareTag("Plastik"))
        {
            Destroy(this.gameObject);
            isOkay = true;
            RandomText.aa = false;
            RandomText.score += 5;
        }
        if (other.CompareTag("PlastikKutu") != CompareTag("Plastik"))
        {
            Destroy(this.gameObject);
            isOkay = false;
            isWrong = true;
            RandomText.bb = false;
       
        }


    }



}
