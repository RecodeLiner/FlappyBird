using UnityEngine;

public class ScoreSetup : MonoBehaviour
{
      private readonly Score _model = new Score(); 
      
      public void Resolve(Initable<Score> target)
      { 
            target.Init(_model);
      }  
}
