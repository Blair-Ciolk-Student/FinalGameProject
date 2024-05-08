using UnityEngine;

public class PlayerInteraction : MonoBehaviour
{

    [SerializeField] private Transform _interactionPoint;
    [SerializeField] float _interactionPointRadius;
    [SerializeField] LayerMask _interactableMask;

    private readonly Collider[] _colliders = new Collider[3];
    [SerializeField] private int _numFound;

    private void Update()
    {
        
    }

}
