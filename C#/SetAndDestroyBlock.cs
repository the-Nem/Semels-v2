using UnityEngine;

public class SetAndDestroyBlock : MonoBehaviour
{
    [SerializeField] private GameObject blocksBase;
    [SerializeField] private GameObject block;
    private GameObject activeBlock;

    private void Start()
    {
        activeBlock = block;
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            SetBlock();
            
        }
        else if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            DestroyBlock();
        }
        else if (Input.GetKeyDown(KeyCode.Mouse2))
        {
            CopyBlock();
        }
    }

    private void SetBlock()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;

        if (!Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            mousePosition.z = Mathf.Abs(Camera.main.transform.position.z);
            Vector2 setPosition = (Camera.main.ScreenToWorldPoint(mousePosition));
            float blockSize = block.transform.localScale.x;
            setPosition.x = Mathf.RoundToInt(setPosition.x / blockSize) * blockSize;
            setPosition.y = Mathf.RoundToInt(setPosition.y / blockSize) * blockSize;

            Instantiate(activeBlock, setPosition, Quaternion.identity);
            Debug.Log("BlockSetted");
        }
    }

    private void DestroyBlock()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            if(hit.transform.tag != "Ubreakable" && hit.transform.tag != "Background" && hit.transform.tag != "Player")
            {
                Destroy(hit.transform.gameObject);
            }
        }
    }
    private void CopyBlock()
    {
        Vector3 mousePosition = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(castPoint, out hit, Mathf.Infinity))
        {
            if (hit.transform.tag == "Block")
            {
                Debug.Log(hit.transform.gameObject.name);
                activeBlock = blocksBase.transform.Find(hit.transform.gameObject.name.Replace("(Clone)", "")).gameObject;
            }
            if (hit.transform.tag == "Tree")
            {
                print("дрэва");
                activeBlock = blocksBase.transform.Find("TreeTrunks").gameObject;
            }
        }
    }
}
