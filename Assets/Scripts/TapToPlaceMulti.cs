using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.ARFoundation;
using UnityEngine.XR.ARSubsystems;
using UnityEngine.UI;

namespace UnityEngine.XR.ARFoundation.Samples
{
    [RequireComponent(typeof(ARRaycastManager))]
    public class TapToPlaceMulti : MonoBehaviour
    {

        
        [SerializeField] Text m_togglePlacing;
        [SerializeField] GameObject m_PlacedPrefab;
        
        public Text togglePlacingText
        {
            get { return m_togglePlacing; }
            set { m_togglePlacing = value; }
        }


        public GameObject placedPrefab
        {
            get { return m_PlacedPrefab; }
            set { m_PlacedPrefab = value; }
        }

        
        public GameObject spawnedObject { get; private set; }

        
        public static event Action onPlacedObject;

        ARRaycastManager m_RaycastManager;

        static List<ARRaycastHit> s_Hits = new List<ARRaycastHit>();

        void Awake()
        {
            m_RaycastManager = GetComponent<ARRaycastManager>();
        }

        void Update()
        {
            if (Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if (touch.phase == TouchPhase.Began)
                {
                    if (m_RaycastManager.Raycast(touch.position, s_Hits, TrackableType.PlaneWithinPolygon))
                    {
                        Pose hitPose = s_Hits[0].pose;
                        
                        spawnedObject = Instantiate(m_PlacedPrefab, hitPose.position, m_PlacedPrefab.transform.rotation);
                        m_PlacedPrefab.GetComponent<Animator>().Play("Idle");
                        
                        if (onPlacedObject != null)
                        {
                            onPlacedObject();
                        }
                    }
                }
            }
        }


        public void ToggleState()
        {
            GetComponent<TapToPlaceMulti>().enabled = !GetComponent<TapToPlaceMulti>().enabled;
            string placingMessage = "";
            if (GetComponent<TapToPlaceMulti>().enabled)
            {
                placingMessage = "Stop Placing Enemies";
            }
            else
            {
                placingMessage = "Start Placing Enemies";
            }

            if (togglePlacingText != null)
                togglePlacingText.text = placingMessage;
        }
    }
}