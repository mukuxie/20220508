using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseBackgroundMusicOnCanvas : MonoBehaviour
{
    //�x�s�I�����֪�AudioSource Component
    private AudioSource bgMusicAudioSource;

    void OnEnable()
    {
        //�b�Ҧ�Game Object����MBackground Music
        bgMusicAudioSource = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource>();

        //�Ȱ�����
        bgMusicAudioSource.Pause();
    }

    void OnDisable()
    {
        //�~�򭵼�
        bgMusicAudioSource.UnPause();
    }

    public class ChangeBackgroundMusicPitchOnStart : MonoBehaviour
    {
        public float pitch; //�g�令��pitch��

        void Start()
        {
            //���o�I������
            AudioSource source = GameObject.FindGameObjectWithTag("Background Music").GetComponent<AudioSource>();
            source.Stop();  //�Ȱ�����
            source.pitch = pitch;  //����pitch
            source.Play();  //�}�l����
        }
    }
}
