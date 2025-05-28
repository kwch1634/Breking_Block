using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField]
    private float speed = 5.0f;
    [SerializeField]
    private float minSpeed = 3.0f;
    [SerializeField]
    private float maxSpeed = 8.0f;
    [SerializeField]
    private float angXm = -1.0f;
    [SerializeField]
    private float angXp = 1.0f;
    [SerializeField]
    private float angYm = -1.0f;
    [SerializeField]
    private float angYp = 1.0f;

    private Rigidbody rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        rb.linearVelocity = new Vector3(speed,speed, 0f);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        LimitSpeed();
        Fixedangle();

    }

    void LimitSpeed()
    {
        float speed = rb.linearVelocity.magnitude;

        if(speed < minSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * minSpeed;�@//���̃X�s�[�h���擾���Đ���i�ŏ��j
            Debug.Log("�X�s�[�h�o�ĂȂ�");
        }
        else if (speed > maxSpeed)
        {
            rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;�@//���̃X�s�[�h���擾���Đ���i�ő�j
            Debug.Log("�X�s�[�h�o�Ă�");
        }
    }

    void Fixedangle()
    {
        Vector3 vel = rb.linearVelocity;
        Vector2 flatVel = new Vector2(vel.x, vel.y);

        float verticalAngle = Vector2.Angle(Vector2.up, flatVel);
        float horizontalAngle = Vector2.Angle(Vector2.right, flatVel);

        if (verticalAngle < 10.0f || verticalAngle > 170.0f)
        {
            vel.x = 1.0f * Mathf.Sign(Random.Range(angXm, angXp)); //�x�N�g���̌����������ɂȂ����Ƃ��A�p�x�������I�ɉ�����
        }
        else if (horizontalAngle < 10.0f || horizontalAngle > 170.0f)
        {
            vel.y = 1.0f * Mathf.Sign(Random.Range(angYm, angYp));//�x�N�g���̌��������s�ɂȂ����Ƃ��A�p�x�������I�ɉ�����
        }
        rb.linearVelocity = vel.normalized * vel.magnitude; //  ���x�ɍ��̃X�s�[�h��������
    }
}
