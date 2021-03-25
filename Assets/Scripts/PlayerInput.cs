using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    private PlayerControls playerControl;

    // Input values
    public float RotateValue { get; private set; }
    public float ForwardValue { get; private set; }

    // Booleans
    public bool CanShoot { get; private set; } = true;
    public bool IsTeleporting { get; private set; } = false;
    public bool HasTeleported { get; private set; } = false;

    // Events
    public event Action ShootPressed = delegate { };
    public event Action TeleportPressed = delegate { };

    private void Awake() => playerControl = new PlayerControls();

    private void OnEnable() => playerControl.Enable();

    private void Start() => GetActionMap();

    private void OnDisable() => playerControl.Disable();

    private void Shoot()
    {
        if (!CanShoot || IsTeleporting) return;

        ShootPressed();
        CanShoot = false;           
    }

    private void Teleport()
    {
        if (HasTeleported) return;

        TeleportPressed();      
    }

    private void GetActionMap()
    {
        if (CompareTag("Tank1"))
        {
            playerControl.Tank1.Forward.performed += ctx => ForwardValue = ctx.ReadValue<float>();
            playerControl.Tank1.Rotate.performed += ctx => RotateValue = ctx.ReadValue<float>();
            playerControl.Tank1.Shoot.performed += ctx => Shoot();
            playerControl.Tank1.Teleport.performed += ctx => Teleport();
        }
        else if (CompareTag("Tank2"))
        {
            playerControl.Tank2.Forward.performed += ctx => ForwardValue = ctx.ReadValue<float>();
            playerControl.Tank2.Rotate.performed += ctx => RotateValue = ctx.ReadValue<float>();
            playerControl.Tank2.Shoot.performed += ctx => Shoot();
            playerControl.Tank2.Teleport.performed += ctx => Teleport();
        }
    }

    public void ResetShooting()
    {
        CanShoot = true;
        HasTeleported = false;
        IsTeleporting = false;
    }

    public void StartTeleport()
    {
        HasTeleported = true;
        IsTeleporting = true;
    }

    public void DoneTeleport() => IsTeleporting = false;
}
