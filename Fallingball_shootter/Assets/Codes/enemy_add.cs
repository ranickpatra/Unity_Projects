using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_add : MonoBehaviour {

    public GameObject prefabs;
    bool added = false;
    EnemyPlane[] ep;

    // Use this for initialization
    void Start () {
        ep = new EnemyPlane[20];
	}
	
	// Update is called once per frame
	void Update () {
		if(!added)
        {
            ep[0] = add();

        }

        ep[0].update();
	}



    private EnemyPlane add()
    {
        added = true;
          GameObject obj = Instantiate(prefabs);
          return new EnemyPlane(obj, Time.realtimeSinceStartup + 50);
    }



    private class EnemyPlane
    {
        public GameObject obj;
        public float time;
        public EnemyPlane(GameObject obj, float time)
        {
            this.obj = obj;
            this.time = time;
        }

        public void destroy()
        {
            Destroy(this.obj);
        }


        public void update()
        {
            if (Time.realtimeSinceStartup > time)
                destroy();
        }


    }


 


}
