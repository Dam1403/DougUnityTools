using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IProjectile{

    void Launch(Vector3 position,Vector3 direction);

    void Travel();

    void Hit();

    void Despawn();
	
}
