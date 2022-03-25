using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimatorController : MonoBehaviour
{
    [SerializeField] private Animator kadınAnimator;
    void Start()
    {
        GameEvents.current.onRaycastHit += ChangeAnimation;
    }

    private void ChangeAnimation()
    {
        kadınAnimator.SetBool("hitted", true);
    }
}
