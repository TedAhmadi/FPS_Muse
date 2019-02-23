using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConcentrateMonitor : MonoBehaviour {

    public GameObject Concentrate01;
    public GameObject Concentrate02;
    public GameObject Concentrate03;
    public GameObject Concentrate04;
    public GameObject Concentrate05;
    public GameObject Concentrate06;
    public GameObject Concentrate07;
    public GameObject Concentrate08;
    public GameObject Concentrate09;
    public GameObject Concentrate010;
    public float currentConcentrate;
    

	// Update is called once per frame
	void Update () {
        currentConcentrate = TransformMapping.currentConcentrate;

        if (currentConcentrate <= 100)
        {
            Concentrate010.SetActive(false);
            if (currentConcentrate <= 90)
            {
                Concentrate09.SetActive(false);
                if (currentConcentrate <= 80)
                {
                    Concentrate08.SetActive(false);
                    if (currentConcentrate <= 70)
                    {
                        Concentrate07.SetActive(false);
                        if (currentConcentrate <= 60)
                        {
                            Concentrate06.SetActive(false);
                            if (currentConcentrate <= 50)
                            {
                                Concentrate05.SetActive(false);
                                if (currentConcentrate <= 40)
                                {
                                    Concentrate04.SetActive(false);
                                    if (currentConcentrate <= 30)
                                    {
                                        Concentrate03.SetActive(false);
                                        if (currentConcentrate <= 20)
                                        {
                                            Concentrate02.SetActive(false);
                                            if (currentConcentrate <= 10)
                                            {
                                                Concentrate01.SetActive(false);

                                            }
                                            else { Concentrate01.SetActive(true); }
                                        }
										else { Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                                    }
									else { Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                                }
								else { Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                            }
							else { Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                        }
						else { Concentrate06.SetActive(true);Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                    }
					else { Concentrate07.SetActive(true);Concentrate06.SetActive(true);Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
                }
				else { Concentrate08.SetActive(true);Concentrate07.SetActive(true);Concentrate06.SetActive(true);Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
            }
			else { Concentrate09.SetActive(true);Concentrate08.SetActive(true);Concentrate07.SetActive(true);Concentrate06.SetActive(true);Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
        }
		else { Concentrate010.SetActive(true);Concentrate09.SetActive(true);Concentrate08.SetActive(true);Concentrate07.SetActive(true);Concentrate06.SetActive(true);Concentrate05.SetActive(true);Concentrate04.SetActive(true);Concentrate03.SetActive(true);Concentrate02.SetActive(true);Concentrate01.SetActive(true); }
	}
}
