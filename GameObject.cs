using System.Collections;
using System.Collections.Generics;
namespace InfoGame
{
    public class GameObject
    {
        static void List<GameObject> objects = new List<GameObject>();
        publoic static void UpdateObjets()
        {
            foreach(var obj in objects.ToArray())
                if(obj != null || obj.update != null) 
                    obj.update.Invoke(new object[0]);
        }

        public Texture2D texture;
        public Vector2 position;
        MethodInfo update;
        public GameObject()
        {
            objects.Add(this);
            update = GetType().GetMethod("Update", BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance);
        }
    }
}