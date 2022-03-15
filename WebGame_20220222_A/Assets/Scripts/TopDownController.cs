using UnityEngine;

namespace Chou
{
    /// <summary>
    /// �W�U�������ⱱ�
    /// ����ʡB�ʵe��s
    /// </summary>
    public class TopDownController : MonoBehaviour
    {
        #region ���:�O�s�Ҧp���ʳt�סB�ʵe�ѼƦW�٩Τ��󵥸��
        //���y�k:�׹��� ������� ���W��(���w �w�]��):
        //[]�ݩ� Attritube
        // SerializeField �ǦC����� - ���i����(�X�{�b�ݩʭ��O Inspector)
        // Header ���D
        //Range �d�� (�ȾA�Ω�ƭ�������ơAint�Bfloat)
        [SerializeField, Header("���ʳt��"), Range(0, 500)]
        private float speed = 1.5f;
        private string parameterRun = "�}���]�B";
        private string parameterDead = "�}�����`";
        private Animator ani;
        private Rigidbody2D rig;
        #endregion

        #region �ƥ�:�{�����J�f(Unity)
        //����ƥ�:����C���ɰ���@���A�B�z��l��
        private void Awake()
        {
            //GetComponent<�x��>()�C �x��:����������
            // ��� ���w ���o����<����W��>()�C ���o���w����s������
            ani = GetComponent<Animator>();
            rig = GetComponent<Rigidbody2D>();
        }

        //��s�ƥ�:��60FPS(Frame per second)
        //���o��J��ƥi�b���ƥ�B�z
        private void Update()
        {
            GetInput();
        }
        #endregion

        #region ��k:���������欰�A�Ҧp���ʥ\��B��s�ʵe
        private void GetInput()
        {
            //�ϥ��R�A���
            //�y�k:���O�W��,�R�A��k�W��(�����޼�)
            //Horizontal �����b�V
            //��:��V���� �P A - �Ǧ^ -1
            //�k:��V�k�� �P D - �Ǧ^ +1
            float h = Input.GetAxis("Horizontal");
            //print() ��X:�N()���T����X��Unity Console ���O(Ctrl + Shift + C)
            print("�����b�V��:" + h);
        }
        #endregion
    }
}

