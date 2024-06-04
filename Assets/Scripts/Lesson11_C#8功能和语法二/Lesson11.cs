using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lesson11 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Vector2 pos = SetPos(PosType.Left);
        print(pos.x);
    }
    public Vector2 SetPos(PosType type) => type switch {
        PosType.Top => new Vector2(1,1),
        PosType.Bottom => new Vector2(0,0),
        PosType.Left => new Vector2(1,0),
        PosType.Right => new Vector2(0,1),
        _ => new Vector2(0,0)
    };

    // Update is called once per frame
    void Update()
    {
        
    }
    public enum PosType {
        Top,Bottom,Left,Right
    }
}
