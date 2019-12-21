using System.Collections;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{


    private void Start()
    {
        //GameObject sta1 = GameObject.Find("Station1");
        //Vector3 pos1 = sta1.transform.position;
        //float speed = 30.0f;
        //float step = speed * Time.deltaTime;
        //pos1.y = 1;
        //transform.position = Vector3.MoveTowards(transform.position, pos1, step);
    }
    void Update()
    {
        Moving();

    }

    public void Moving()
    {
        #region ゲームオブジェクト発見
        GameObject sta1  = GameObject.Find("Station1");
        GameObject sta2  = GameObject.Find("Station2");
        GameObject sta3  = GameObject.Find("Station3");
        GameObject sta4  = GameObject.Find("Station4");
        GameObject sta5  = GameObject.Find("Station5");
        GameObject sta6  = GameObject.Find("Station6");
        GameObject sta7  = GameObject.Find("Station7");
        GameObject sta8  = GameObject.Find("Station8");
        GameObject sta9 = GameObject.Find("Station9");
        GameObject sta10 = GameObject.Find("Station10");
        GameObject sta11 = GameObject.Find("Station11");
        GameObject sta12 = GameObject.Find("Station12");
        GameObject sta13 = GameObject.Find("Station13");
        GameObject sta14 = GameObject.Find("Station14");
        GameObject sta15 = GameObject.Find("Station15");
        GameObject sta16 = GameObject.Find("Station16");
        GameObject sta17 = GameObject.Find("Station17");
        GameObject sta18 = GameObject.Find("Station18");
        GameObject sta19 = GameObject.Find("Station19");
        GameObject sta20 = GameObject.Find("Station20");
        GameObject sta21 = GameObject.Find("Station21");
        GameObject sta22 = GameObject.Find("Station22");
        GameObject sta23 = GameObject.Find("Station23");
        GameObject sta24 = GameObject.Find("Station24");
        GameObject sta25 = GameObject.Find("Station25");
        GameObject sta26 = GameObject.Find("Station26");
        GameObject sta27 = GameObject.Find("Station27");
        GameObject sta28 = GameObject.Find("Station28");
        #endregion

        #region 駅の座標取得
        //Transform station = cube.transform;
        Vector3 pos1  = sta1.transform.position;
        Vector3 pos2  = sta2.transform.position;
        Vector3 pos3  = sta3.transform.position;
        Vector3 pos4  = sta4.transform.position;
        Vector3 pos5  = sta5.transform.position;
        Vector3 pos6  = sta6.transform.position;
        Vector3 pos7  = sta7.transform.position;
        Vector3 pos8  = sta8.transform.position;
        Vector3 pos9  = sta9.transform.position;
        Vector3 pos10 = sta10.transform.position;
        Vector3 pos11 = sta11.transform.position;
        Vector3 pos12 = sta12.transform.position;
        Vector3 pos13 = sta13.transform.position;
        Vector3 pos14 = sta14.transform.position;
        Vector3 pos15 = sta15.transform.position;
        Vector3 pos16 = sta16.transform.position;
        Vector3 pos17 = sta17.transform.position;
        Vector3 pos18 = sta18.transform.position;
        Vector3 pos19 = sta19.transform.position;
        Vector3 pos20 = sta20.transform.position;
        Vector3 pos21 = sta21.transform.position;
        Vector3 pos22 = sta22.transform.position;
        Vector3 pos23 = sta23.transform.position;
        Vector3 pos24 = sta24.transform.position;
        Vector3 pos25 = sta25.transform.position;
        Vector3 pos26 = sta26.transform.position;
        Vector3 pos27 = sta27.transform.position;
        Vector3 pos28 = sta28.transform.position;
        #endregion

        #region ｙ座標調整
        pos1.y  = 1;
        pos2.y  = 1;
        pos3.y  = 1;
        pos4.y  = 1;
        pos5.y  = 1;
        pos6.y  = 1;
        pos7.y  = 1;
        pos8.y  = 1;
        pos9.y  = 1;
        pos10.y = 1;
        pos11.y = 1;
        pos12.y = 1;
        pos13.y = 1;
        pos14.y = 1;
        pos15.y = 1;
        pos16.y = 1;
        pos17.y = 1;
        pos18.y = 1;
        pos19.y = 1;
        pos20.y = 1;
        pos21.y = 1;
        pos22.y = 1;
        pos23.y = 1;
        pos24.y = 1;
        pos25.y = 1;
        pos26.y = 1;
        pos27.y = 1;
        pos28.y = 1;
        #endregion

        float speed = 30.0f;
        float step = speed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            int num = Dice();
            Debug.Log(num);

            for (int r = 1; r <= num; r++)
            {
                #region 電車の移動（if文）
                if (transform.position == pos1)
                {
                    while(transform.position != pos2)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos2, step);
                    }
                    continue;
                }

                if (transform.position == pos2)
                {
                    while(transform.position != pos3)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos3, step);
                    }
                    continue;
                }

                if (transform.position == pos3)
                {
                    while(transform.position != pos4)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos4, step);
                    }
                    continue;
                }

                if (transform.position == pos4)
                {
                    while (transform.position != pos5)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos5, step);
                    }
                    continue;
                }

                if (transform.position == pos5)
                {
                    while (transform.position != pos6)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos6, step);
                    }
                    continue;
                }

                if (transform.position == pos6)
                {
                    while (transform.position != pos7)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos7, step);
                    }
                    continue;
                }

                if (transform.position == pos7)
                {
                    while (transform.position != pos8)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos8, step);
                    }
                    transform.eulerAngles = new Vector3(0f, 180, 0f);
                    continue;
                }

                if (transform.position == pos8)
                {
                    while (transform.position != pos9)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos9, step);
                    }
                    continue;
                }

                if (transform.position == pos9)
                {
                    while (transform.position != pos10)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos10, step);
                    }
                    continue;
                }

                if (transform.position == pos10)
                {
                    while (transform.position != pos11)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos11, step);
                    }
                    continue;
                }

                if (transform.position == pos11)
                {
                    while (transform.position != pos12)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos12, step);
                    }
                    continue;
                }

                if (transform.position == pos12)
                {
                    while (transform.position != pos13)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos13, step);
                    }
                    continue;
                }

                if (transform.position == pos13)
                {
                    while (transform.position != pos14)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos14, step);
                    }
                    continue;
                }

                if (transform.position == pos14)
                {
                    while (transform.position != pos15)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos15, step);
                    }
                    transform.eulerAngles = new Vector3(0f, 90, 0f);
                    continue;
                }

                if (transform.position == pos15)
                {
                    while (transform.position != pos16)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos16, step);
                    }
                    continue;
                }

                if (transform.position == pos16)
                {
                    while (transform.position != pos17)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos17, step);
                    }
                    continue;
                }

                if (transform.position == pos17)
                {
                    while (transform.position != pos18)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos18, step);
                    }
                    continue;
                }

                if (transform.position == pos18)
                {
                    while (transform.position != pos19)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos19, step);
                    }
                    continue;
                }

                if (transform.position == pos19)
                {
                    while (transform.position != pos20)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos20, step);
                    }
                    continue;
                }

                if (transform.position == pos20)
                {
                    while (transform.position != pos21)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos21, step);
                    }
                    continue;
                }

                if (transform.position == pos21)
                {
                    while (transform.position != pos22)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos22, step);
                    }
                    transform.eulerAngles = new Vector3(0f, 180, 0f);
                    continue;
                }

                if (transform.position == pos22)
                {
                    while (transform.position != pos23)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos23, step);
                    }
                    continue;
                }

                if (transform.position == pos23)
                {
                    while (transform.position != pos24)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos24, step);
                    }
                    continue;
                }

                if (transform.position == pos24)
                {
                    while (transform.position != pos25)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos25, step);
                    }
                    continue;
                }

                if (transform.position == pos25)
                {
                    while (transform.position != pos26)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos26, step);
                    }
                    continue;
                }

                if (transform.position == pos26)
                {
                    while (transform.position != pos27)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos27, step);
                    }
                    continue;
                }

                if (transform.position == pos27)
                {
                    while (transform.position != pos28)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos28, step);
                    }
                    continue;
                }

                if (transform.position == pos28)
                {
                    while (transform.position != pos1)
                    {
                        transform.position = Vector3.MoveTowards(transform.position, pos1, step);
                    }
                    transform.eulerAngles = new Vector3(0f, -90, 0f);
                    continue;
                }
                #endregion
            }
        }

        if (transform.position == pos1)
        {
            Turn();
        }

        //if (transform.position == pos8)
        //{
        //    turn();
        //}


    }

    public void Turn()
    {
            transform.eulerAngles = new Vector3(0f, -90, 0f);
    }

    public int Dice()
    {
            int index = Random.Range(1, 7);
            return index;
    }

  

    void Wait()
    {
        GameObject sta2 = GameObject.Find("Station2");
        Vector3 pos2 = sta2.transform.position;
        float speed = 30.0f;
        float step = speed * Time.deltaTime;
        pos2.y = 1;
        transform.position = Vector3.MoveTowards(transform.position, pos2, step);
    }
}


