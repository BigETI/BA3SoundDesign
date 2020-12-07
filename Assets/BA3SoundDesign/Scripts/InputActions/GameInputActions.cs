// GENERATED AUTOMATICALLY FROM 'Assets/BA3SoundDesign/InputActions/GameInputActions.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

namespace BA3SoundDesign.InputActions
{
    public class @GameInputActions : IInputActionCollection, IDisposable
    {
        public InputActionAsset asset { get; }
        public @GameInputActions()
        {
            asset = InputActionAsset.FromJson(@"{
    ""name"": ""GameInputActions"",
    ""maps"": [
        {
            ""name"": ""GameActionMap"",
            ""id"": ""bff89d64-67a7-4fdb-b854-a5c935008157"",
            ""actions"": [
                {
                    ""name"": ""Any"",
                    ""type"": ""Button"",
                    ""id"": ""1dbc2a11-6f1e-484a-ba97-c024502911a4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""e7a8a92e-2be2-4bb4-b331-ffbdee6a817f"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Jump"",
                    ""type"": ""Button"",
                    ""id"": ""b622004e-3180-4c29-82d1-7998320933df"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Look"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2f613cdf-b9b4-4edb-929e-9ccd89d6b9e4"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""LookAnalogue"",
                    ""type"": ""PassThrough"",
                    ""id"": ""d27c0d6d-a457-4d3f-b005-cbb6a11a7366"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Louder"",
                    ""type"": ""Button"",
                    ""id"": ""3db98889-44ea-496e-9f79-780702971bff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Move"",
                    ""type"": ""PassThrough"",
                    ""id"": ""e4f0d2c7-ba06-4db9-b556-0eeb674885ef"",
                    ""expectedControlType"": ""Vector2"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Mute"",
                    ""type"": ""Button"",
                    ""id"": ""5892e952-f7af-43d3-b4ff-e939c5b9b0a7"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Quieter"",
                    ""type"": ""Button"",
                    ""id"": ""bd61aa2e-1748-44c6-8074-32f08415a34b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Solo"",
                    ""type"": ""Button"",
                    ""id"": ""2d7bbc86-5523-485d-aff8-84378268a813"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Sprint"",
                    ""type"": ""PassThrough"",
                    ""id"": ""2ef35bd7-7296-45fb-b241-bbe9a764045b"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""6f8dce34-142f-4f62-8fde-0329adf60a01"",
                    ""path"": ""<Gamepad>/leftStick"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""WASDKeys"",
                    ""id"": ""542e7fa0-f064-411f-86fa-d86a1c165c59"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Move"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""e0f54271-e8db-48f9-8ebb-7eb3bc5176f9"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""89701386-2571-412b-85a9-70f4e3a14828"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""6729c624-d849-435f-827f-1ed831d904c5"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""c671a7e5-f2bc-4122-89ff-aca1d628d34d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Move"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""fabe7606-c3a5-47ed-b943-59551c5f9938"",
                    ""path"": ""<Gamepad>/rightTrigger"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2712abf0-300d-4679-b49e-8e01456d8199"",
                    ""path"": ""<Keyboard>/shift"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Sprint"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""73bb7211-d0a2-4225-8103-5e22260f302f"",
                    ""path"": ""<Gamepad>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Mute"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""edc27e1b-6281-4176-ac61-3704d6369d23"",
                    ""path"": ""<Keyboard>/m"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Mute"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""21849d29-b77d-4a01-a500-a7e71466fc8d"",
                    ""path"": ""<Keyboard>/end"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Mute"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5c5a2773-f38b-4b8b-a7e6-5ddfb358671d"",
                    ""path"": ""<Gamepad>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Solo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""7611cc74-9674-41dc-8d26-0b43d78b57fc"",
                    ""path"": ""<Keyboard>/n"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Solo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""effc80f5-d80a-4cf4-9525-54551a1dc232"",
                    ""path"": ""<Keyboard>/home"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Solo"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8336ae38-90c9-42c7-a0ee-93f584b3274c"",
                    ""path"": ""<Gamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d6cc636a-28a6-4189-a9d3-405736fc0e74"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Jump"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""36fcd7a0-fc50-472b-ae08-591ff19b1517"",
                    ""path"": ""<Gamepad>/leftShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Quieter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""54c87842-683e-446f-9481-efc048f335ff"",
                    ""path"": ""<Keyboard>/numpadMinus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Quieter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5fd701f-95d1-4e29-890f-57e9202ab0ec"",
                    ""path"": ""<Keyboard>/#(-)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Quieter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""717a1d09-360b-4460-b057-ac8629b0c910"",
                    ""path"": ""<Keyboard>/downArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Quieter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e96ec680-ee4a-405e-a35a-a4a62e7bb5bb"",
                    ""path"": ""<Keyboard>/pageDown"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Quieter"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""55489f98-60ec-43ec-adf3-e1aafe91d81b"",
                    ""path"": ""<Mouse>/delta"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=0.03125,y=-0.03125)"",
                    ""groups"": ""GameControl"",
                    ""action"": ""Look"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""46bc8517-6211-408f-9378-2d155b9df8b5"",
                    ""path"": ""<Gamepad>/rightShoulder"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Louder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""97674459-4b83-4993-8847-d80a1f47d429"",
                    ""path"": ""<Keyboard>/numpadPlus"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Louder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bc462520-3487-44b8-a7e5-033721d1d98a"",
                    ""path"": ""<Keyboard>/#(+)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Louder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""86156389-46b9-485b-b883-029ce474c6fd"",
                    ""path"": ""<Keyboard>/upArrow"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Louder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f6aa8f48-8764-4249-9dd3-e8367bd89038"",
                    ""path"": ""<Keyboard>/pageUp"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Louder"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""4c5c392b-8427-48a8-988b-ca2fe6e70d89"",
                    ""path"": ""<Gamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""98d5b51f-46f6-4317-b310-ea66663f647b"",
                    ""path"": ""<Keyboard>/e"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""GameControl"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d807c2aa-4af1-4aa0-85e5-7ee53d672269"",
                    ""path"": ""<Gamepad>/rightStick"",
                    ""interactions"": """",
                    ""processors"": ""ScaleVector2(x=120,y=-90)"",
                    ""groups"": ""GameControl"",
                    ""action"": ""LookAnalogue"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""01120dc1-bad6-4d85-aea7-0fe7cade29ab"",
                    ""path"": ""*/{Back}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9d746e25-c94b-4ecf-b83a-d07825dec4eb"",
                    ""path"": ""*/{Cancel}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""04ad6bee-ee1c-439e-8bdf-bff153a96581"",
                    ""path"": ""*/{Forward}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26cefe10-7c6d-4620-9e33-f6f0ac33a81f"",
                    ""path"": ""*/{Menu}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""bd5610cb-ca58-4ff5-a85c-a654cf71af5c"",
                    ""path"": ""*/{Modifier}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""afd5005e-b070-4f9a-af16-9179b9d86f8f"",
                    ""path"": ""*/{PrimaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c085a8b9-8e3d-4947-b554-7ea423150f81"",
                    ""path"": ""*/{PrimaryTrigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""a212ef19-31b7-4324-93bc-b93228626a3c"",
                    ""path"": ""*/{SecondaryAction}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""57cd74a0-f423-4f7f-b97a-3d5341eb1d4b"",
                    ""path"": ""*/{SecondaryTrigger}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""598f479d-226a-4681-9c02-03116577b281"",
                    ""path"": ""*/{Submit}"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f32922cf-9c3e-48c2-921f-2b0eaa88bb3e"",
                    ""path"": ""<Keyboard>/anyKey"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""392523c4-24b2-4f64-a3dc-55292bdb4e3b"",
                    ""path"": ""<Mouse>/press"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Any"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""GameControl"",
            ""bindingGroup"": ""GameControl"",
            ""devices"": [
                {
                    ""devicePath"": ""<Gamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<Mouse>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
            // GameActionMap
            m_GameActionMap = asset.FindActionMap("GameActionMap", throwIfNotFound: true);
            m_GameActionMap_Any = m_GameActionMap.FindAction("Any", throwIfNotFound: true);
            m_GameActionMap_Interact = m_GameActionMap.FindAction("Interact", throwIfNotFound: true);
            m_GameActionMap_Jump = m_GameActionMap.FindAction("Jump", throwIfNotFound: true);
            m_GameActionMap_Look = m_GameActionMap.FindAction("Look", throwIfNotFound: true);
            m_GameActionMap_LookAnalogue = m_GameActionMap.FindAction("LookAnalogue", throwIfNotFound: true);
            m_GameActionMap_Louder = m_GameActionMap.FindAction("Louder", throwIfNotFound: true);
            m_GameActionMap_Move = m_GameActionMap.FindAction("Move", throwIfNotFound: true);
            m_GameActionMap_Mute = m_GameActionMap.FindAction("Mute", throwIfNotFound: true);
            m_GameActionMap_Quieter = m_GameActionMap.FindAction("Quieter", throwIfNotFound: true);
            m_GameActionMap_Solo = m_GameActionMap.FindAction("Solo", throwIfNotFound: true);
            m_GameActionMap_Sprint = m_GameActionMap.FindAction("Sprint", throwIfNotFound: true);
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

        // GameActionMap
        private readonly InputActionMap m_GameActionMap;
        private IGameActionMapActions m_GameActionMapActionsCallbackInterface;
        private readonly InputAction m_GameActionMap_Any;
        private readonly InputAction m_GameActionMap_Interact;
        private readonly InputAction m_GameActionMap_Jump;
        private readonly InputAction m_GameActionMap_Look;
        private readonly InputAction m_GameActionMap_LookAnalogue;
        private readonly InputAction m_GameActionMap_Louder;
        private readonly InputAction m_GameActionMap_Move;
        private readonly InputAction m_GameActionMap_Mute;
        private readonly InputAction m_GameActionMap_Quieter;
        private readonly InputAction m_GameActionMap_Solo;
        private readonly InputAction m_GameActionMap_Sprint;
        public struct GameActionMapActions
        {
            private @GameInputActions m_Wrapper;
            public GameActionMapActions(@GameInputActions wrapper) { m_Wrapper = wrapper; }
            public InputAction @Any => m_Wrapper.m_GameActionMap_Any;
            public InputAction @Interact => m_Wrapper.m_GameActionMap_Interact;
            public InputAction @Jump => m_Wrapper.m_GameActionMap_Jump;
            public InputAction @Look => m_Wrapper.m_GameActionMap_Look;
            public InputAction @LookAnalogue => m_Wrapper.m_GameActionMap_LookAnalogue;
            public InputAction @Louder => m_Wrapper.m_GameActionMap_Louder;
            public InputAction @Move => m_Wrapper.m_GameActionMap_Move;
            public InputAction @Mute => m_Wrapper.m_GameActionMap_Mute;
            public InputAction @Quieter => m_Wrapper.m_GameActionMap_Quieter;
            public InputAction @Solo => m_Wrapper.m_GameActionMap_Solo;
            public InputAction @Sprint => m_Wrapper.m_GameActionMap_Sprint;
            public InputActionMap Get() { return m_Wrapper.m_GameActionMap; }
            public void Enable() { Get().Enable(); }
            public void Disable() { Get().Disable(); }
            public bool enabled => Get().enabled;
            public static implicit operator InputActionMap(GameActionMapActions set) { return set.Get(); }
            public void SetCallbacks(IGameActionMapActions instance)
            {
                if (m_Wrapper.m_GameActionMapActionsCallbackInterface != null)
                {
                    @Any.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnAny;
                    @Any.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnAny;
                    @Any.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnAny;
                    @Interact.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Interact.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Interact.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnInteract;
                    @Jump.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Jump.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Jump.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnJump;
                    @Look.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @Look.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @Look.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLook;
                    @LookAnalogue.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLookAnalogue;
                    @LookAnalogue.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLookAnalogue;
                    @LookAnalogue.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLookAnalogue;
                    @Louder.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLouder;
                    @Louder.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLouder;
                    @Louder.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnLouder;
                    @Move.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Move.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Move.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMove;
                    @Mute.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMute;
                    @Mute.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMute;
                    @Mute.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnMute;
                    @Quieter.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnQuieter;
                    @Quieter.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnQuieter;
                    @Quieter.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnQuieter;
                    @Solo.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSolo;
                    @Solo.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSolo;
                    @Solo.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSolo;
                    @Sprint.started -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                    @Sprint.performed -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                    @Sprint.canceled -= m_Wrapper.m_GameActionMapActionsCallbackInterface.OnSprint;
                }
                m_Wrapper.m_GameActionMapActionsCallbackInterface = instance;
                if (instance != null)
                {
                    @Any.started += instance.OnAny;
                    @Any.performed += instance.OnAny;
                    @Any.canceled += instance.OnAny;
                    @Interact.started += instance.OnInteract;
                    @Interact.performed += instance.OnInteract;
                    @Interact.canceled += instance.OnInteract;
                    @Jump.started += instance.OnJump;
                    @Jump.performed += instance.OnJump;
                    @Jump.canceled += instance.OnJump;
                    @Look.started += instance.OnLook;
                    @Look.performed += instance.OnLook;
                    @Look.canceled += instance.OnLook;
                    @LookAnalogue.started += instance.OnLookAnalogue;
                    @LookAnalogue.performed += instance.OnLookAnalogue;
                    @LookAnalogue.canceled += instance.OnLookAnalogue;
                    @Louder.started += instance.OnLouder;
                    @Louder.performed += instance.OnLouder;
                    @Louder.canceled += instance.OnLouder;
                    @Move.started += instance.OnMove;
                    @Move.performed += instance.OnMove;
                    @Move.canceled += instance.OnMove;
                    @Mute.started += instance.OnMute;
                    @Mute.performed += instance.OnMute;
                    @Mute.canceled += instance.OnMute;
                    @Quieter.started += instance.OnQuieter;
                    @Quieter.performed += instance.OnQuieter;
                    @Quieter.canceled += instance.OnQuieter;
                    @Solo.started += instance.OnSolo;
                    @Solo.performed += instance.OnSolo;
                    @Solo.canceled += instance.OnSolo;
                    @Sprint.started += instance.OnSprint;
                    @Sprint.performed += instance.OnSprint;
                    @Sprint.canceled += instance.OnSprint;
                }
            }
        }
        public GameActionMapActions @GameActionMap => new GameActionMapActions(this);
        private int m_GameControlSchemeIndex = -1;
        public InputControlScheme GameControlScheme
        {
            get
            {
                if (m_GameControlSchemeIndex == -1) m_GameControlSchemeIndex = asset.FindControlSchemeIndex("GameControl");
                return asset.controlSchemes[m_GameControlSchemeIndex];
            }
        }
        public interface IGameActionMapActions
        {
            void OnAny(InputAction.CallbackContext context);
            void OnInteract(InputAction.CallbackContext context);
            void OnJump(InputAction.CallbackContext context);
            void OnLook(InputAction.CallbackContext context);
            void OnLookAnalogue(InputAction.CallbackContext context);
            void OnLouder(InputAction.CallbackContext context);
            void OnMove(InputAction.CallbackContext context);
            void OnMute(InputAction.CallbackContext context);
            void OnQuieter(InputAction.CallbackContext context);
            void OnSolo(InputAction.CallbackContext context);
            void OnSprint(InputAction.CallbackContext context);
        }
    }
}
