﻿using System;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Mathematics;
using Unity.Transforms;
using UnityEngine;

[RequiresEntityConversion]
public class AddSluggerSingleton : MonoBehaviour, IConvertGameObjectToEntity
{
    public float unitspeed = 55.0f;
    public int teamnum;
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        /*
 * This is commented because we only want it to be selected if it is spawned
        var select = new Selectable
        {
            SelectSize = 5.0f
        };
        dstManager.AddComponentData(entity, select);
*/
        var pool = new TagUnitPool
        {

        };

        dstManager.AddComponentData(entity, pool);

        var targetinput = new Target
        {
            Destination = float3.zero,


        };
        dstManager.AddComponentData(entity, targetinput);

        var ratenum = new Rate
        {
            Value = 0,
            Cooldown = 1,
            Max = 4
        };
        dstManager.AddComponentData(entity, ratenum);

        var damagenum = new Damage
        {
            Max = 30,
            Min = 15,
            Type = AttackType.Piercing
        };
        dstManager.AddComponentData(entity, damagenum);

        var rangenum = new Range
        {
            MaxEngagement = 20.0f,
            Max = 45.0f,
            Min = 1.0f,
            Value = 0f
        };
        dstManager.AddComponentData(entity, rangenum);

        var hp = new Health
        {
            Max = 75,
            Value = 75,
            Type = ArmorType.Light
        };
        dstManager.AddComponentData(entity, hp);


        var movementSpeed = new MovementSpeed
        {
            Value = unitspeed
        };
        dstManager.AddComponentData(entity, movementSpeed);

        var copyTransform = new CopyTransformToGameObject { };
        dstManager.AddComponentData(entity, copyTransform);

        var tag = new TagRaider
        {
        };
        dstManager.AddComponentData(entity, tag);

        var tag2 = new TagMeleeUnit
        {

        };
        dstManager.AddComponentData(entity, tag2);

        var tag3 = new TagUnit
        {

        };
        dstManager.AddComponentData(entity, tag3);

        var team = new Team
        {
            Number = teamnum,
        };
        dstManager.AddComponentData(entity, team);

        var animations = new AnimationsComponent
        {

        };
        dstManager.AddComponentData(entity, animations);
        var shader = new ShaderComponent
        {
            change = false,
            HealBuff = 0,
            SpeedBuff = 0,
            Freeze = 0
        };
        dstManager.AddComponentData(entity, shader);
    }
}
