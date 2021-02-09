using UnityEngine.SceneManagement;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Stickies")]
    public GameObject[] MyTentacles = new GameObject[4];
    //0 forward     1 right     2 back      3 left
    public GameObject[] MyNewExtremities = new GameObject[4];
    public int MyNewExtremitiesCount = 0;
    public GameObject[] ObjectsDetectors;
    //0 Forward    1 RightForward   2 Right    3 RightBack    4 Back   5 LeftBack    6 Left   7 LeftForward
    [Header("Click Particles")]
    public GameObject ClickParticle;
    public GameObject UnClickParticle;
    void Update()
    {
             if ((Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.Keypad6)) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[2].GetComponent<Detector>().TouchedObject == null
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
        else if ((Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.Keypad4)) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[6].GetComponent<Detector>().TouchedObject == null
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
        else if ((Input.GetKeyDown(KeyCode.W)||Input.GetKeyDown(KeyCode.UpArrow)||Input.GetKeyDown(KeyCode.Keypad8)) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[0].GetComponent<Detector>().TouchedObject == null
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
        else if ((Input.GetKeyDown(KeyCode.S)||Input.GetKeyDown(KeyCode.DownArrow)||Input.GetKeyDown(KeyCode.Keypad2)) && MyNewExtremitiesCount < 1 )//&& ObjectsDetectors[4].GetComponent<Detector>().TouchedObject == null
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
        else if ((Input.GetKeyDown(KeyCode.D)||Input.GetKeyDown(KeyCode.E)||Input.GetKeyDown(KeyCode.RightArrow)||Input.GetKeyDown(KeyCode.Keypad6)||Input.GetKeyDown(KeyCode.Keypad9)) && MyNewExtremitiesCount > 0)
        {
            if (MyNewExtremitiesCount < 1)
            {
                gameObject.transform.Rotate(Vector3.up, 90f);
                FindObjectOfType<AudioManager>().Play("Drag");
            }
            else
            {
                int turn=0;
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
                                    if ((ObjectsDetectors[0].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[1].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[1].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                    }
                                }else if (i == 6)
                                {
                                    if ((ObjectsDetectors[7].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[7].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[0].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                    }
                                }
                                else
                                {
                                    if ((ObjectsDetectors[i + 1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i+1].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[i + 2].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i+2].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[i+2].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                    }
                                }

                            }
                        }
                    }

                }
                Debug.Log(turn);
                if (turn==MyNewExtremitiesCount)
                {
                    gameObject.transform.Rotate(Vector3.up, 90f);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }

            }
        }
        else if ((Input.GetKeyDown(KeyCode.A)||Input.GetKeyDown(KeyCode.Q)||Input.GetKeyDown(KeyCode.LeftArrow)||Input.GetKeyDown(KeyCode.Keypad4)||Input.GetKeyDown(KeyCode.Keypad7)) && MyNewExtremitiesCount > 0)
        {
            if (MyNewExtremitiesCount < 1)
            {
                gameObject.transform.Rotate(Vector3.up, -90f);
                FindObjectOfType<AudioManager>().Play("Drag");
            }
            else
            {
                int turn=0;
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
                                    if ((ObjectsDetectors[7].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[7].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[6].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[6].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[6].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                        
                                    }
                                }
                                else if (i == 1)
                                {
                                    if ((ObjectsDetectors[0].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[0].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[7].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[7].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[7].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                        
                                    }
                                }
                                else
                                {
                                    if ((ObjectsDetectors[i - 1].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i - 1].GetComponent<Detector>().TouchedObject.tag=="Filter")&&(ObjectsDetectors[i - 2].GetComponent<Detector>().TouchedObject == null||ObjectsDetectors[i - 2].GetComponent<Detector>().TouchedObject.tag=="Filter"||ObjectsDetectors[i-2].GetComponent<Detector>().TouchedObject.name[0]=='H'))
                                    {
                                        turn++;
                                        
                                    }
                                }
                            }
                        }
                    }
                }
                Debug.Log(turn);
                if (turn==MyNewExtremitiesCount)
                {
                    gameObject.transform.Rotate(Vector3.up, -90f);
                    FindObjectOfType<AudioManager>().Play("Drag");
                }
            }
            

        }
        else if (Input.GetKeyDown(KeyCode.Space)||Input.GetKeyDown(KeyCode.F))
        {
            if (MyNewExtremitiesCount < 1)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (MyTentacles[i].GetComponent<Tentacle>().TouchedObject != null)
                    {
                            FindObjectOfType<AudioManager>().Play("Click");
                            Destroy(Instantiate(ClickParticle,transform.position,Quaternion.Euler(90,0,0)),1f);
                            MyNewExtremities[i] = MyTentacles[i].GetComponent<Tentacle>().TouchedObject;
                            MyTentacles[i].GetComponent<Tentacle>().TouchedObject.transform.parent = transform;
                            MyNewExtremitiesCount++;
                            
                    }
                }
            }
            else
            {
                Destroy(Instantiate(UnClickParticle,transform.position,Quaternion.Euler(90,0,0)),1f);
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
