using System.Collections;
using System.IO;
using System.Collections.Generic;
using UnityEngine;
using Unity.Entities;

public class FilepathGrabSystem : ComponentSystem
{
    protected override void OnAwake()
    {
       // Entities.ForEach((ref FilepathStorageComponent filepathStorageCompnent) => {  filepathStorageCompnent.filepaths = Application.per})
    }
}
