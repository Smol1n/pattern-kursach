using UnityEngine;

[CreateAssetMenu(fileName = "CharacterData", menuName = "Game Data/Character Data")]
public class CharacterData : ScriptableObject
{
    public float movementSpeed = 150f;
    public float crouchSpeed = 50f;
    public float crouchColliderHeight = 1f;
    public float normalColliderHeight = 2f;
    public float rotationSpeed = 60f;
    public float crouchRotationSpeed = 30f;
    public float jumpForce = 10f;
}
