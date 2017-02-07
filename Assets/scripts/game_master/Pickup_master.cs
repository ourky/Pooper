using UnityEngine;
using System.Collections;
using System;

public class Pickup_master : MonoBehaviour {
    public static Pickup_master PickupMaster = null;

	// Use this for initialization
	void Start () {
        PickupMaster = this;
	}

    public void giveBuff(Buff buff)
    {
        Shoot_Bullet.PlayerShootBullet.giveBuffPlayer(buff);
    }
}
