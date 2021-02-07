using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public GameObject[] MyTentacles = new GameObject[4];
    //0 forward
    //1 right
    //2 back
    //3 left
    public GameObject[] MyNewExtremities = new GameObject[4];
    public int MyNewExtremitiesCount = 0;
    public GameObject[] ObjectsDetectors;
    //0 Forward
    //1 RightForward
    //2 Right
    //3 RightBack
    //4 Back
    //5 LeftBack
    //6 Left
    //7 LeftForward

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[2].GetComponent<Detector>().TouchedObject == null
        {
            try
            {
                if (ObjectsDetectors[2].GetComponent<Detector>().TouchedObject.tag=="Static")
                {
                
                }
                else if (ObjectsDetectors[2].GetComponent<Detector>().TouchedObject.tag=="Filter")
                {
                    
                }
                else
                {
                    gameObject.transform.parent.transform.Translate(Vector3.right, Space.World);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }
            }
            catch (System.Exception)
            {
                gameObject.transform.parent.transform.Translate(Vector3.right, Space.World);
            }

            
        }
        else if (Input.GetKeyDown(KeyCode.A) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[6].GetComponent<Detector>().TouchedObject == null
        {
            try
            {
                if (ObjectsDetectors[6].GetComponent<Detector>().TouchedObject.tag=="Static")
                {
                
                }
                else if (ObjectsDetectors[6].GetComponent<Detector>().TouchedObject.tag=="Filter")
                {
                    
                }
                else
                {
                    gameObject.transform.parent.transform.Translate(Vector3.left, Space.World);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }
            }
            catch (System.Exception)
            {
                gameObject.transform.parent.transform.Translate(Vector3.left, Space.World);
                
            }

            
        }
        else if (Input.GetKeyDown(KeyCode.W) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[0].GetComponent<Detector>().TouchedObject == null
        {
            try
            {
                if (ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.tag=="Static")
                {
               
                }
                else if (ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.tag=="Filter")
                {
                    
                }
                else
                {
                    gameObject.transform.parent.transform.Translate(Vector3.forward, Space.World);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }
            }
            catch (System.Exception)
            {
                gameObject.transform.parent.transform.Translate(Vector3.forward, Space.World);
            }

            
        }
        else if (Input.GetKeyDown(KeyCode.S) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[4].GetComponent<Detector>().TouchedObject == null
        {
            try
            {
                if (ObjectsDetectors[4].GetComponent<Detector>().TouchedObject.tag=="Static")
                {

                }
                else if (ObjectsDetectors[4].GetComponent<Detector>().TouchedObject.tag=="Filter")
                {
                    
                }
                else
                {
                    gameObject.transform.parent.transform.Translate(Vector3.back, Space.World);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }
            }
            catch (System.Exception)
            {
                
                gameObject.transform.parent.transform.Translate(Vector3.back, Space.World);
            }

            
        }
        else if (Input.GetKeyDown(KeyCode.E))
        {
            if (MyNewExtremitiesCount < 1)
            {
                gameObject.transform.Rotate(Vector3.up, 90f);
                FindObjectOfType<AudioManager>().Play("Drag");
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    if (MyNewExtremities[j] != null)
                    {
                        for (int i = 0; i < 8; i += 2)
                        {
                            if (MyNewExtremities[j] == ObjectsDetectors[i].GetComponent<Detector>().TouchedObject)
                            {
                                if (i == 7)
                                {
                                    if (ObjectsDetectors[1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[1].GetComponent<Detector>().TouchedObject.tag=="Filter")
                                    {
                                        gameObject.transform.Rotate(Vector3.up, 90f);
                                        FindObjectOfType<AudioManager>().Play("Drag");
                                    }
                                }
                                else
                                {
                                    if (ObjectsDetectors[i + 1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i+1].GetComponent<Detector>().TouchedObject.tag=="Filter")
                                    {
                                        gameObject.transform.Rotate(Vector3.up, 90f);
                                        FindObjectOfType<AudioManager>().Play("Drag");
                                    }
                                }

                            }
                        }
                    }

                }

            }
        }
        else if (Input.GetKeyDown(KeyCode.Q))
        {
            if (MyNewExtremitiesCount < 1)
            {
                gameObject.transform.Rotate(Vector3.up, -90f);
                FindObjectOfType<AudioManager>().Play("Drag");
            }
            else
            {
                for (int j = 0; j < 4; j++)
                {
                    if (MyNewExtremities[j] != null)
                    {
                        for (int i = 0; i < 8; i += 2)
                        {
                            if (MyNewExtremities[j] == ObjectsDetectors[i].GetComponent<Detector>().TouchedObject)
                            {
                                if (i == 0)
                                {
                                    if (ObjectsDetectors[7].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[7].GetComponent<Detector>().TouchedObject.tag=="Filter")
                                    {
                                        gameObject.transform.Rotate(Vector3.up, -90f);
                                        FindObjectOfType<AudioManager>().Play("Drag");
                                    }
                                }
                                else
                                {
                                    if (ObjectsDetectors[i - 1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i - 1].GetComponent<Detector>().TouchedObject.tag=="Filter")
                                    {
                                        gameObject.transform.Rotate(Vector3.up, -90f);
                                        FindObjectOfType<AudioManager>().Play("Drag");
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        else if (Input.GetKeyDown(KeyCode.F))
        {
            if (MyNewExtremitiesCount < 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (MyTentacles[i].GetComponent<Tentacle>().TouchedObject != null)
                    {
                        if (MyNewExtremities[i] != MyTentacles[i].GetComponent<Tentacle>().TouchedObject)
                        {
                            MyTentacles[i].GetComponent<Tentacle>().TouchedObject.transform.parent = transform;
                            MyNewExtremities[i] = MyTentacles[i].GetComponent<Tentacle>().TouchedObject;
                            MyNewExtremitiesCount++;
                            FindObjectOfType<AudioManager>().Play("Click");
                        }

                    }
                }
            }
            else
            {
                for (int i = 0; i < 4; i++)
                {
                    if (MyNewExtremities[i] != null)
                    {
                        MyNewExtremities[i].transform.parent = null;
                        MyNewExtremities[i] = null;
                    }
                }
                MyNewExtremitiesCount = 0;
            }
        }
    }
}
