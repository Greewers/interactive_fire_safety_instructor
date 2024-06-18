using UnityEngine;

public class Arrow : MonoBehaviour
{
    public Node NextNodes;
    public Node NextSmokeNodes;

    private Node _currentNode;
    private bool _isSmoked = false;

    private void Start()
    {
        _currentNode = gameObject.GetComponentInParent<Node>();
        _isSmoked = MapSceneController.isSmoked;
    }

    public void OnClick()
    {
        if (_isSmoked == true) 
        {
            NextSmokeNodes.gameObject.SetActive(true);
            _currentNode.gameObject.SetActive(false);
        }
        else 
        {
            NextNodes.gameObject.SetActive(true);
            _currentNode.gameObject.SetActive(false);
        }

        _currentNode.AddTimer();
    }
}
