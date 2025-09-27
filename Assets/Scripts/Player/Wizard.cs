using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class Wizard : MonoBehaviour, IWeapon
{

    [SerializeField] private float _speedBullet = 20f;
    [SerializeField] private float _lifeTime = 3f;
    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Transform _firePos;
    [SerializeField] private GameObject _prefabBullet;
    

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        Destroy(gameObject, _lifeTime );
    }

    void Update()
    {
      
        
    }
    public void Use()
    {
        
        
            Instantiate(_prefabBullet, _firePos.position, _firePos.rotation);
        
    }

    public void Broke()
    {

    }

    public void change()
    {

    }
}
