// GENERATED AUTOMATICALLY FROM 'Assets/Scripts/InputSystem/PlayerControls.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @PlayerControls : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @PlayerControls()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""PlayerControls"",
    ""maps"": [
        {
            ""name"": ""Tank1"",
            ""id"": ""963e83f1-f8ae-45f8-96a1-bc09a0dd5710"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""10e22539-95be-42a2-af60-58c0be38fe38"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""595abf18-5141-4a79-af26-2626f5629d18"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""868981f2-a284-48f1-94da-5d1771baea6e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Teleport"",
                    ""type"": ""Button"",
                    ""id"": ""b387bbc6-861b-47e9-a978-63212dee43fe"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Rotate"",
                    ""id"": ""05a023aa-90da-48ca-a904-86c25e6adb47"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""4a77a125-1596-4cd2-8933-6cc568f8b230"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""10ccae43-a315-4ad6-94da-5736cc421901"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""5019aa98-06af-4c06-9630-b02c1a127ee0"",
                    ""path"": ""<Keyboard>/j"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55d18830-f104-46f8-b514-099b591ef8df"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c5a238a-8a00-459b-bf43-d37bbb70d8b5"",
                    ""path"": ""<Keyboard>/k"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""Tank2"",
            ""id"": ""7b0f47ce-9c2f-49ca-9704-e3a5a3d2d43e"",
            ""actions"": [
                {
                    ""name"": ""Rotate"",
                    ""type"": ""PassThrough"",
                    ""id"": ""521f9232-bd1a-4fd4-aed2-b17bf021729f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Forward"",
                    ""type"": ""PassThrough"",
                    ""id"": ""c771ad22-5d3f-4fae-864c-1f9a753efff2"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Shoot"",
                    ""type"": ""PassThrough"",
                    ""id"": ""18974c1a-0314-4f72-a2bf-5935f4dc5734"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Teleport"",
                    ""type"": ""Button"",
                    ""id"": ""a7c12cf2-39c7-427a-a478-a4e859e65245"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""Rotate"",
                    ""id"": ""8b52aef7-2a95-4d08-a1d4-7a7a4af277c1"",
                    ""path"": ""1DAxis"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""negative"",
                    ""id"": ""cd8d4a52-9e6d-4692-972b-100bf9e64697"",
                    ""path"": ""<Keyboard>/leftArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""positive"",
                    ""id"": ""1b0960a9-cead-4605-9e51-640f18f92221"",
                    ""path"": ""<Keyboard>/rightArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Rotate"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""c3282519-308d-4371-8980-29d441d1c835"",
                    ""path"": ""<Mouse>/leftButton"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Shoot"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""59e479d1-dcb1-407c-9993-094842a6715e"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Forward"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""694844e5-9667-44ba-bc9b-32d4e5baee43"",
                    ""path"": ""<Mouse>/rightButton"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Teleport"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""WASD"",
            ""bindingGroup"": ""WASD"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // Tank1
        m_Tank1 = asset.FindActionMap("Tank1", throwIfNotFound: true);
        m_Tank1_Rotate = m_Tank1.FindAction("Rotate", throwIfNotFound: true);
        m_Tank1_Forward = m_Tank1.FindAction("Forward", throwIfNotFound: true);
        m_Tank1_Shoot = m_Tank1.FindAction("Shoot", throwIfNotFound: true);
        m_Tank1_Teleport = m_Tank1.FindAction("Teleport", throwIfNotFound: true);
        // Tank2
        m_Tank2 = asset.FindActionMap("Tank2", throwIfNotFound: true);
        m_Tank2_Rotate = m_Tank2.FindAction("Rotate", throwIfNotFound: true);
        m_Tank2_Forward = m_Tank2.FindAction("Forward", throwIfNotFound: true);
        m_Tank2_Shoot = m_Tank2.FindAction("Shoot", throwIfNotFound: true);
        m_Tank2_Teleport = m_Tank2.FindAction("Teleport", throwIfNotFound: true);
    }

    public void Dispose()
    {
        UnityEngine.Object.Destroy(asset);
    }

    public InputBinding? bindingMask
    {
        get => asset.bindingMask;
        set => asset.bindingMask = value;
    }

    public ReadOnlyArray<InputDevice>? devices
    {
        get => asset.devices;
        set => asset.devices = value;
    }

    public ReadOnlyArray<InputControlScheme> controlSchemes => asset.controlSchemes;

    public bool Contains(InputAction action)
    {
        return asset.Contains(action);
    }

    public IEnumerator<InputAction> GetEnumerator()
    {
        return asset.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Enable()
    {
        asset.Enable();
    }

    public void Disable()
    {
        asset.Disable();
    }

    // Tank1
    private readonly InputActionMap m_Tank1;
    private ITank1Actions m_Tank1ActionsCallbackInterface;
    private readonly InputAction m_Tank1_Rotate;
    private readonly InputAction m_Tank1_Forward;
    private readonly InputAction m_Tank1_Shoot;
    private readonly InputAction m_Tank1_Teleport;
    public struct Tank1Actions
    {
        private @PlayerControls m_Wrapper;
        public Tank1Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Tank1_Rotate;
        public InputAction @Forward => m_Wrapper.m_Tank1_Forward;
        public InputAction @Shoot => m_Wrapper.m_Tank1_Shoot;
        public InputAction @Teleport => m_Wrapper.m_Tank1_Teleport;
        public InputActionMap Get() { return m_Wrapper.m_Tank1; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Tank1Actions set) { return set.Get(); }
        public void SetCallbacks(ITank1Actions instance)
        {
            if (m_Wrapper.m_Tank1ActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnRotate;
                @Forward.started -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnForward;
                @Shoot.started -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnShoot;
                @Teleport.started -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_Tank1ActionsCallbackInterface.OnTeleport;
            }
            m_Wrapper.m_Tank1ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
            }
        }
    }
    public Tank1Actions @Tank1 => new Tank1Actions(this);

    // Tank2
    private readonly InputActionMap m_Tank2;
    private ITank2Actions m_Tank2ActionsCallbackInterface;
    private readonly InputAction m_Tank2_Rotate;
    private readonly InputAction m_Tank2_Forward;
    private readonly InputAction m_Tank2_Shoot;
    private readonly InputAction m_Tank2_Teleport;
    public struct Tank2Actions
    {
        private @PlayerControls m_Wrapper;
        public Tank2Actions(@PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Rotate => m_Wrapper.m_Tank2_Rotate;
        public InputAction @Forward => m_Wrapper.m_Tank2_Forward;
        public InputAction @Shoot => m_Wrapper.m_Tank2_Shoot;
        public InputAction @Teleport => m_Wrapper.m_Tank2_Teleport;
        public InputActionMap Get() { return m_Wrapper.m_Tank2; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(Tank2Actions set) { return set.Get(); }
        public void SetCallbacks(ITank2Actions instance)
        {
            if (m_Wrapper.m_Tank2ActionsCallbackInterface != null)
            {
                @Rotate.started -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnRotate;
                @Rotate.performed -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnRotate;
                @Rotate.canceled -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnRotate;
                @Forward.started -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnForward;
                @Forward.performed -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnForward;
                @Forward.canceled -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnForward;
                @Shoot.started -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnShoot;
                @Shoot.performed -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnShoot;
                @Shoot.canceled -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnShoot;
                @Teleport.started -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnTeleport;
                @Teleport.performed -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnTeleport;
                @Teleport.canceled -= m_Wrapper.m_Tank2ActionsCallbackInterface.OnTeleport;
            }
            m_Wrapper.m_Tank2ActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Rotate.started += instance.OnRotate;
                @Rotate.performed += instance.OnRotate;
                @Rotate.canceled += instance.OnRotate;
                @Forward.started += instance.OnForward;
                @Forward.performed += instance.OnForward;
                @Forward.canceled += instance.OnForward;
                @Shoot.started += instance.OnShoot;
                @Shoot.performed += instance.OnShoot;
                @Shoot.canceled += instance.OnShoot;
                @Teleport.started += instance.OnTeleport;
                @Teleport.performed += instance.OnTeleport;
                @Teleport.canceled += instance.OnTeleport;
            }
        }
    }
    public Tank2Actions @Tank2 => new Tank2Actions(this);
    private int m_WASDSchemeIndex = -1;
    public InputControlScheme WASDScheme
    {
        get
        {
            if (m_WASDSchemeIndex == -1) m_WASDSchemeIndex = asset.FindControlSchemeIndex("WASD");
            return asset.controlSchemes[m_WASDSchemeIndex];
        }
    }
    public interface ITank1Actions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTeleport(InputAction.CallbackContext context);
    }
    public interface ITank2Actions
    {
        void OnRotate(InputAction.CallbackContext context);
        void OnForward(InputAction.CallbackContext context);
        void OnShoot(InputAction.CallbackContext context);
        void OnTeleport(InputAction.CallbackContext context);
    }
}
