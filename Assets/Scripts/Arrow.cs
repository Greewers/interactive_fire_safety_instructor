using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Node NextNodes;

    private Node _currentNode;

    private void Start()
    {
        _currentNode = gameObject.GetComponentInParent<Node>();
    }

    public void OnClick()
    {
        NextNodes.gameObject.SetActive(true);
        _currentNode.gameObject.SetActive(false);
        _currentNode.AddTimer();
    }
}
