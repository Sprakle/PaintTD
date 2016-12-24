using UnityEngine;
using System.Collections;

public class EntityHealth : MonoBehaviour
{

	[SerializeField]
	int MaxHealth;

	[SerializeField]
	bool IsInvincible;

	int health { get; set; }

	// Use this for initialization
	void Start()
	{
		health = MaxHealth;
	}

	void DamageEntity(int value)
	{
		if (!IsInvincible)
		{
			health -= value;
			if (health <= 0)
				KillEntity();
		}
	}

	void KillEntity()
	{

	}

}
