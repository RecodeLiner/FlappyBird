using UnityEngine;

public class GameOverSetup : MonoBehaviour
{ 
      private readonly GameOverModel _model = new GameOverModel(); 
          
      public void Resolve(Initable<GameOverModel> target)
      { 
            target.Init(_model);
      } 
}
