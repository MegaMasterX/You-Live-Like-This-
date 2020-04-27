// GENERATED AUTOMATICALLY FROM 'Assets/MasterInput.inputactions'

using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Utilities;

public class @MasterInput : IInputActionCollection, IDisposable
{
    public InputActionAsset asset { get; }
    public @MasterInput()
    {
        asset = InputActionAsset.FromJson(@"{
    ""name"": ""MasterInput"",
    ""maps"": [
        {
            ""name"": ""UI_Menu"",
            ""id"": ""5fd3f77f-d9ca-454f-a481-3b7cff78f91f"",
            ""actions"": [
                {
                    ""name"": ""Up"",
                    ""type"": ""Button"",
                    ""id"": ""d7d74dfd-201c-4858-8e74-31470e0743ff"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Down"",
                    ""type"": ""Button"",
                    ""id"": ""ef6f551f-6da8-465c-b653-9000d618fb3a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Confirm"",
                    ""type"": ""Button"",
                    ""id"": ""5d049e41-2498-4023-a506-5a22d321fb2a"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                },
                {
                    ""name"": ""Cancel"",
                    ""type"": ""Button"",
                    ""id"": ""bd32eb0c-ae48-4c3b-90b0-c17dea35c47e"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": ""Press""
                }
            ],
            ""bindings"": [
                {
                    ""name"": """",
                    ""id"": ""ffd34915-1dfd-4fa4-a8d0-11974aa42e6e"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c43e0bc5-25ae-4690-921a-1cb22ea10969"",
                    ""path"": ""<DualShockGamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;PS4"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""682f91ad-2ac9-4552-9105-1c10b004bcc7"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;PS4"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f707cda1-93fb-4254-aafb-3267f7ecc92f"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""dd0e607d-3e2c-4462-94c2-41e118489ac9"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""e060542f-f258-48b7-9716-e0d1c5e86f9c"",
                    ""path"": ""<Gamepad>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3a5a6528-78c3-4b0b-bc08-41807adeaa15"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Up"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c7e059e9-28cf-49f4-bed6-de32929d5f9b"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": ""Press"",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""69d752c1-8194-4334-8b0d-85e6562ccb5b"",
                    ""path"": ""<DualShockGamepad>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;PS4"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""ad6cce64-658d-499d-933b-d8ea3f09ad6e"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;PS4"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""5e0c1da7-3b08-4048-8089-479579b8e318"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c74068df-018a-4173-b037-1f98d26adadf"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""20a86659-51a6-471e-b30f-1ce04f2467ce"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3c6d0d98-5356-4a4d-bfc8-817f88aa4bc7"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Down"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""8e726d3c-71ab-42d7-88a4-5374e7f4cfdf"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""102a93f2-af20-4fe3-aaad-eb54cf3f211c"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""15447add-01a1-4298-b1c1-3b94165b3249"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard;PS4"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""2a9757d0-830f-490b-a1c4-b59550381c99"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Confirm"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""40363e0b-3987-4bc7-9074-01bb40503907"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""421e42f6-efb4-467e-a985-dd831d475ac5"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d655f3f2-5184-4987-b232-4028bce87dcd"",
                    ""path"": ""<DualShockGamepad>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""08c6c374-2edd-4648-803a-7e4108e9da2f"",
                    ""path"": ""<XInputController>/buttonEast"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Cancel"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        },
        {
            ""name"": ""InGame"",
            ""id"": ""526fc7a8-b33d-4485-b063-0b613250c8f6"",
            ""actions"": [
                {
                    ""name"": ""Character"",
                    ""type"": ""Button"",
                    ""id"": ""fe3ca458-2b3c-4362-b6cc-f02521c57e50"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""Interact"",
                    ""type"": ""Button"",
                    ""id"": ""2abbe44a-ea40-42c6-9570-02c4e206d38d"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                },
                {
                    ""name"": ""CloseGame"",
                    ""type"": ""Button"",
                    ""id"": ""772b282c-3ba1-4570-ab23-bf7154c8c4d4"",
                    ""expectedControlType"": ""Button"",
                    ""processors"": """",
                    ""interactions"": """"
                }
            ],
            ""bindings"": [
                {
                    ""name"": ""WASD"",
                    ""id"": ""cf579764-073e-4a31-a925-cfc0a43f4c32"",
                    ""path"": ""2DVector(mode=2)"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""097b43ee-d439-46fc-bdae-dbc7c48b9ed8"",
                    ""path"": ""<Keyboard>/w"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""f3002581-4659-4a65-999b-f8760003cd80"",
                    ""path"": ""<Keyboard>/s"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""84ee7525-c03b-4f97-ac1d-e4605c3cc36f"",
                    ""path"": ""<Keyboard>/a"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""9df50cb3-dcf0-48bd-b401-0650d582874d"",
                    ""path"": ""<Keyboard>/d"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""MovePS4"",
                    ""id"": ""ddbb4f79-21d2-4d3e-b76d-e07e6ef44263"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""d0f609a4-0db3-471f-b220-2fee422bb22a"",
                    ""path"": ""<DualShockGamepad>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""6017484b-d1cb-4c18-a2f5-7a7613766df3"",
                    ""path"": ""<DualShockGamepad>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""a36978f8-aea5-47cc-b86a-4a9cc11b1bb6"",
                    ""path"": ""<DualShockGamepad>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""75ffa057-9971-4ee1-ba9d-8de2f94ac0be"",
                    ""path"": ""<DualShockGamepad>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""53043751-95f9-4410-af59-33321eb3e8ad"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""2fe808c6-773a-4572-a71d-0c1e1d57b4d9"",
                    ""path"": ""<XInputController>/leftStick/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""4b030697-20ac-4d68-95ce-733fe57ef8e9"",
                    ""path"": ""<XInputController>/leftStick/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""55c136fd-f2d0-42c7-88ed-5c3cf0d2dea3"",
                    ""path"": ""<XInputController>/leftStick/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""de352424-1739-4062-8e70-eedfc5f45cb6"",
                    ""path"": ""<XInputController>/leftStick/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""2D Vector"",
                    ""id"": ""c4c9cf42-5dca-4805-a5f7-583aba66072c"",
                    ""path"": ""2DVector"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": """",
                    ""action"": ""Character"",
                    ""isComposite"": true,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": ""up"",
                    ""id"": ""3d45a96f-5978-40d9-859b-eae640d4ece8"",
                    ""path"": ""<XInputController>/dpad/up"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""down"",
                    ""id"": ""8f1acfd7-431b-4df5-9643-6b8aee163011"",
                    ""path"": ""<XInputController>/dpad/down"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""left"",
                    ""id"": ""7de209d1-37a3-4e81-845e-4ad15a1f1bc0"",
                    ""path"": ""<XInputController>/dpad/left"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": ""right"",
                    ""id"": ""fe41e7f7-3a7f-47e6-af96-70975834937c"",
                    ""path"": ""<XInputController>/dpad/right"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Character"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": true
                },
                {
                    ""name"": """",
                    ""id"": ""f59bb054-37a4-4484-a7df-65b8b2c450db"",
                    ""path"": ""<Keyboard>/space"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""26f64988-c137-4413-995f-6a4c767623fb"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""6da930e7-adad-4a8e-8546-ba957c74df72"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""9ed2adeb-6aa1-4a90-ba57-e6f252f2c8c6"",
                    ""path"": ""<DualShockGamepad>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""3b81761f-a75a-4ebf-b590-33b5d0a00edf"",
                    ""path"": ""<XInputController>/buttonSouth"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""Interact"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""f5f833a5-edef-4268-b5bd-1168b0ba15fa"",
                    ""path"": ""<Keyboard>/escape"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""d8c2f282-66d3-497a-8ab0-c630ccd0b22b"",
                    ""path"": ""<XInputController>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""13c93aaf-dd2b-4daa-a3a8-5d625c417fe3"",
                    ""path"": ""<DualShockGamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Keyboard"",
                    ""action"": ""CloseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""c10f46a8-5859-412d-a17e-567c3b94f51b"",
                    ""path"": ""<Gamepad>/start"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""PS4"",
                    ""action"": ""CloseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                },
                {
                    ""name"": """",
                    ""id"": ""34d2ab66-34c8-4886-88a1-d948ac8ad544"",
                    ""path"": ""<Gamepad>/select"",
                    ""interactions"": """",
                    ""processors"": """",
                    ""groups"": ""Xbox"",
                    ""action"": ""CloseGame"",
                    ""isComposite"": false,
                    ""isPartOfComposite"": false
                }
            ]
        }
    ],
    ""controlSchemes"": [
        {
            ""name"": ""Keyboard"",
            ""bindingGroup"": ""Keyboard"",
            ""devices"": [
                {
                    ""devicePath"": ""<Keyboard>"",
                    ""isOptional"": false,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": true,
                    ""isOR"": false
                },
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": true,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""PS4"",
            ""bindingGroup"": ""PS4"",
            ""devices"": [
                {
                    ""devicePath"": ""<DualShockGamepad>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        },
        {
            ""name"": ""Xbox"",
            ""bindingGroup"": ""Xbox"",
            ""devices"": [
                {
                    ""devicePath"": ""<XInputController>"",
                    ""isOptional"": false,
                    ""isOR"": false
                }
            ]
        }
    ]
}");
        // UI_Menu
        m_UI_Menu = asset.FindActionMap("UI_Menu", throwIfNotFound: true);
        m_UI_Menu_Up = m_UI_Menu.FindAction("Up", throwIfNotFound: true);
        m_UI_Menu_Down = m_UI_Menu.FindAction("Down", throwIfNotFound: true);
        m_UI_Menu_Confirm = m_UI_Menu.FindAction("Confirm", throwIfNotFound: true);
        m_UI_Menu_Cancel = m_UI_Menu.FindAction("Cancel", throwIfNotFound: true);
        // InGame
        m_InGame = asset.FindActionMap("InGame", throwIfNotFound: true);
        m_InGame_Character = m_InGame.FindAction("Character", throwIfNotFound: true);
        m_InGame_Interact = m_InGame.FindAction("Interact", throwIfNotFound: true);
        m_InGame_CloseGame = m_InGame.FindAction("CloseGame", throwIfNotFound: true);
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

    // UI_Menu
    private readonly InputActionMap m_UI_Menu;
    private IUI_MenuActions m_UI_MenuActionsCallbackInterface;
    private readonly InputAction m_UI_Menu_Up;
    private readonly InputAction m_UI_Menu_Down;
    private readonly InputAction m_UI_Menu_Confirm;
    private readonly InputAction m_UI_Menu_Cancel;
    public struct UI_MenuActions
    {
        private @MasterInput m_Wrapper;
        public UI_MenuActions(@MasterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Up => m_Wrapper.m_UI_Menu_Up;
        public InputAction @Down => m_Wrapper.m_UI_Menu_Down;
        public InputAction @Confirm => m_Wrapper.m_UI_Menu_Confirm;
        public InputAction @Cancel => m_Wrapper.m_UI_Menu_Cancel;
        public InputActionMap Get() { return m_Wrapper.m_UI_Menu; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(UI_MenuActions set) { return set.Get(); }
        public void SetCallbacks(IUI_MenuActions instance)
        {
            if (m_Wrapper.m_UI_MenuActionsCallbackInterface != null)
            {
                @Up.started -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnUp;
                @Up.performed -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnUp;
                @Up.canceled -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnUp;
                @Down.started -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnDown;
                @Down.performed -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnDown;
                @Down.canceled -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnDown;
                @Confirm.started -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.performed -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnConfirm;
                @Confirm.canceled -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnConfirm;
                @Cancel.started -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnCancel;
                @Cancel.performed -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnCancel;
                @Cancel.canceled -= m_Wrapper.m_UI_MenuActionsCallbackInterface.OnCancel;
            }
            m_Wrapper.m_UI_MenuActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Up.started += instance.OnUp;
                @Up.performed += instance.OnUp;
                @Up.canceled += instance.OnUp;
                @Down.started += instance.OnDown;
                @Down.performed += instance.OnDown;
                @Down.canceled += instance.OnDown;
                @Confirm.started += instance.OnConfirm;
                @Confirm.performed += instance.OnConfirm;
                @Confirm.canceled += instance.OnConfirm;
                @Cancel.started += instance.OnCancel;
                @Cancel.performed += instance.OnCancel;
                @Cancel.canceled += instance.OnCancel;
            }
        }
    }
    public UI_MenuActions @UI_Menu => new UI_MenuActions(this);

    // InGame
    private readonly InputActionMap m_InGame;
    private IInGameActions m_InGameActionsCallbackInterface;
    private readonly InputAction m_InGame_Character;
    private readonly InputAction m_InGame_Interact;
    private readonly InputAction m_InGame_CloseGame;
    public struct InGameActions
    {
        private @MasterInput m_Wrapper;
        public InGameActions(@MasterInput wrapper) { m_Wrapper = wrapper; }
        public InputAction @Character => m_Wrapper.m_InGame_Character;
        public InputAction @Interact => m_Wrapper.m_InGame_Interact;
        public InputAction @CloseGame => m_Wrapper.m_InGame_CloseGame;
        public InputActionMap Get() { return m_Wrapper.m_InGame; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled => Get().enabled;
        public static implicit operator InputActionMap(InGameActions set) { return set.Get(); }
        public void SetCallbacks(IInGameActions instance)
        {
            if (m_Wrapper.m_InGameActionsCallbackInterface != null)
            {
                @Character.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCharacter;
                @Character.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCharacter;
                @Character.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCharacter;
                @Interact.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnInteract;
                @Interact.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnInteract;
                @Interact.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnInteract;
                @CloseGame.started -= m_Wrapper.m_InGameActionsCallbackInterface.OnCloseGame;
                @CloseGame.performed -= m_Wrapper.m_InGameActionsCallbackInterface.OnCloseGame;
                @CloseGame.canceled -= m_Wrapper.m_InGameActionsCallbackInterface.OnCloseGame;
            }
            m_Wrapper.m_InGameActionsCallbackInterface = instance;
            if (instance != null)
            {
                @Character.started += instance.OnCharacter;
                @Character.performed += instance.OnCharacter;
                @Character.canceled += instance.OnCharacter;
                @Interact.started += instance.OnInteract;
                @Interact.performed += instance.OnInteract;
                @Interact.canceled += instance.OnInteract;
                @CloseGame.started += instance.OnCloseGame;
                @CloseGame.performed += instance.OnCloseGame;
                @CloseGame.canceled += instance.OnCloseGame;
            }
        }
    }
    public InGameActions @InGame => new InGameActions(this);
    private int m_KeyboardSchemeIndex = -1;
    public InputControlScheme KeyboardScheme
    {
        get
        {
            if (m_KeyboardSchemeIndex == -1) m_KeyboardSchemeIndex = asset.FindControlSchemeIndex("Keyboard");
            return asset.controlSchemes[m_KeyboardSchemeIndex];
        }
    }
    private int m_PS4SchemeIndex = -1;
    public InputControlScheme PS4Scheme
    {
        get
        {
            if (m_PS4SchemeIndex == -1) m_PS4SchemeIndex = asset.FindControlSchemeIndex("PS4");
            return asset.controlSchemes[m_PS4SchemeIndex];
        }
    }
    private int m_XboxSchemeIndex = -1;
    public InputControlScheme XboxScheme
    {
        get
        {
            if (m_XboxSchemeIndex == -1) m_XboxSchemeIndex = asset.FindControlSchemeIndex("Xbox");
            return asset.controlSchemes[m_XboxSchemeIndex];
        }
    }
    public interface IUI_MenuActions
    {
        void OnUp(InputAction.CallbackContext context);
        void OnDown(InputAction.CallbackContext context);
        void OnConfirm(InputAction.CallbackContext context);
        void OnCancel(InputAction.CallbackContext context);
    }
    public interface IInGameActions
    {
        void OnCharacter(InputAction.CallbackContext context);
        void OnInteract(InputAction.CallbackContext context);
        void OnCloseGame(InputAction.CallbackContext context);
    }
}
