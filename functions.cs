public class functions // for older uni
{
    public GameObject Instantiate(GameObject obj, Vector2 pos, Quaternion rot)
    {
        GameObject new_obj = obj;
        new_obj.transform.position = pos;
        new_obj.transform.rotation = rot;
        return new_obj;
    }
}
