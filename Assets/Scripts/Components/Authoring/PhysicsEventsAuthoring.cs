using Unity.Entities;
using UnityEngine;

[DisallowMultipleComponent]
public class PhysicsEventsAuthoring : MonoBehaviour, IConvertGameObjectToEntity
{
    public void Convert(Entity entity, EntityManager dstManager, GameObjectConversionSystem conversionSystem)
    {
        dstManager.AddBuffer<CollisionBuffer>(entity);
        dstManager.AddBuffer<TriggerBuffer>(entity);
    }
}