﻿using UnityEngine;
using System.Collections.Generic;
using System.Collections;
using Byjus.Gamepod.PathFinder.Util;

namespace Byjus.Gamepod.PathFinder.Verticals {
    public class InputParser : MonoBehaviour {
        public IExtInputListener inputListener;

        IVisionService visionService;
        int inputCount;

        public void Init() {
            visionService = Factory.GetVisionService();
            inputCount = 0;

            StartCoroutine(ListenForInput());
        }

        IEnumerator ListenForInput() {
            yield return new WaitForSeconds(Constants.INPUT_DELAY);
            inputCount++;
            

            inputListener.OnInputStart();

            var objs = visionService.GetVisionObjects();
            Process(objs);
            inputListener.OnInputEnd();

            StartCoroutine(ListenForInput());
        }

        void Process(List<ExtInput> objs) {

        }
    }

    public interface IExtInputListener {
        void OnInputStart();

        void OnPlaceValueUpdated(int newValue);
        void OntTilePlaced();
        void onTileRemoved();

        void OnInputEnd();
    }

}