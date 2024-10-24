using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{
    [SerializeField] private Vector2 movementSpeed;
    private Vector2 offset;
    private Material material;
    private Rigidbody2D player;
    private Vector2 lastPosition;

    private void Awake()
    {
        material = GetComponent<SpriteRenderer>().material;
        player = GameObject.Find("Ranita").GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        player = player.GetComponent<Rigidbody2D>();
        lastPosition = player.position;
    }

    private void Update()
    {
        Vector2 desplazamiento = player.position - lastPosition;

        if (desplazamiento != Vector2.zero)
        {
            offset = (player.velocity.x / 10) * movementSpeed * Time.deltaTime;
        }
        material.mainTextureOffset += offset;
    }
}
