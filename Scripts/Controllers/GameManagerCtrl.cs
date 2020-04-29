using UnityEngine;
using Byjus.Gamepod.PathFinder.Views;
using Byjus.Gamepod.PathFinder.Verticals;
using System.Collections.Generic;

namespace Byjus.Gamepod.PathFinder.Controllers {
    public class GameManagerCtrl : IGameManagerCtrl, IExtInputListener {
        public IGameManagerView view;

        public void Init() {
        }

        public void OnInputEnd() {
            throw new System.NotImplementedException();
        }

        public void OnInputStart() {
            throw new System.NotImplementedException();
        }

        public void OnPlaceValueUpdated(int newValue) {
            throw new System.NotImplementedException();
        }

        public void onTileRemoved() {
            throw new System.NotImplementedException();
        }

        public void OntTilePlaced() {
            throw new System.NotImplementedException();
        }
    }

    public interface IGameManagerCtrl {
        void Init();
    }
}