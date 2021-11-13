using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteMeScriptMoveAroundMono : MonoBehaviour
{

    public KeyboardWriteMono m_target;
    public void GoLeft(bool on) {
        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.Q, on ? PressType.Down : PressType.Up));
    }
    public void GoRight(bool on) {

        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.D, on ? PressType.Down : PressType.Up));
    }
    public void GoDown(bool on) {

        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.S, on ? PressType.Down : PressType.Up));
    }
    public void GoUp(bool on) {

        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.Z, on ? PressType.Down : PressType.Up));
    }
    public void GoJump(bool on)
    {
        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.Space, on ? PressType.Down : PressType.Up));

    }
    public void GoCrouch(bool on)
    {
        m_target.Stroke(new KeyboardTouchPressRequest(KeyboardTouch.Shift, on ? PressType.Down : PressType.Up));

    }
   
}
