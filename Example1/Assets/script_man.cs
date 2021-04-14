using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script_man : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GetComponent<Animator>().SetBool( "isPunch", false );

        if ( Input.GetKeyDown("up") ){　    GetComponent<Animator>().SetBool( "isWalk", true );       }
        else if ( Input.GetKeyUp("up") ){　    GetComponent<Animator>().SetBool( "isWalk", false );       }

        if ( Input.GetKeyDown("down") ){　    GetComponent<Animator>().SetBool( "isBack", true );       }
        else if ( Input.GetKeyUp("down") ){　    GetComponent<Animator>().SetBool( "isBack", false );       }

        if ( Input.GetKeyDown("p") ){　    GetComponent<Animator>().SetBool( "isPunch", true );       }

        if ( Input.GetKey("left") ){　  transform.Rotate( 0, -0.5f, 0 );     }        
        if ( Input.GetKey("right") ){　  transform.Rotate( 0, 0.5f, 0 );     }

    }
}
