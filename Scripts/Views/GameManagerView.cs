using UnityEngine;
using Byjus.Gamepod.PathFinder.Controllers;

namespace Byjus.Gamepod.PathFinder.Views {

    public class GameManagerView : MonoBehaviour, IGameManagerView {
        public IGameManagerCtrl ctrl;
    }

    public interface IGameManagerView {
        
    }
}