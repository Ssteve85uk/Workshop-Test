#pragma strict

function OnCollisionEnter (col : Collision)
{
    if(col.gameObject.name == "fire")
    {
        Destroy(col.gameObject);
    }
}