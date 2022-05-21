using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Curvature : MonoBehaviour
{
    // Start is called before the first frame update
    public int _state;
    [SerializeField] GameObject eye_normal;
    [SerializeField] GameObject eye_def;
    [SerializeField] GameObject eye_cur;
    [SerializeField] GameObject _object;
    [SerializeField] GameObject _dest;
    [SerializeField] Slider slider;
    [SerializeField] GameObject lens;
    [SerializeField] GameObject dlens;
    [SerializeField] GameObject c_lens;

    private int lens_;


    void Start()
    {
        _state = 0;
        lens_ = 0;
        eye_normal.SetActive(true);
        eye_cur.SetActive(false);
        eye_def.SetActive(false);
        lens.SetActive(false);
        c_lens.SetActive(false);
    }
    private void Update()
    {
        if (_state == 1 & lens_ == 0)
        {
            Vector3 pos = _object.transform.position;
            if (pos.x < 16)
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = (20 + (slider.value / (float)12.515)) * (float)1.2048;
                _dest.transform.position = _pos;
            }
            else
            {
                Vector3 _pos = _dest.transform.position;
                _pos.x = (float)25.8145;
                _dest.transform.position = _pos;
            }
        }
    }

    // Update is called once per frame

    public void Ls_Button_clicked()
    {
        if (lens_ == 0)
        {
            c_lens.SetActive(true);
            Vector3 _pos = _dest.transform.position;
            _pos.x = (float)25.8145;
            _dest.transform.position = _pos;
            lens_ = 1;
        }
        else
        {
            lens_ = 0;
            c_lens.SetActive(false);
        }

    }

    public void D_Button_clicked()
    {
        _state = 0;
        lens_ = 0;
    }
    public void C_Button_clicked()
    {
        if (_state == 0)
        {
            eye_normal.SetActive(false);
            eye_cur.SetActive(true);
            eye_def.SetActive(false);
            c_lens.SetActive(false);
            dlens.SetActive(false);
            lens.SetActive(true);
            _state = 1;
        }
        else
        {
            eye_normal.SetActive(true);
            lens.SetActive(false);
            dlens.SetActive(false);
            c_lens.SetActive(false);
            eye_cur.SetActive(false);
            eye_def.SetActive(false);
            _state = 0;
        }
    }
}
