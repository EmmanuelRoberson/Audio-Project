using System.Collections;
using System.Collections.Generic;
using Unity.Entities;
using Unity.Collections;

public struct FilepathStorageComponent : IComponentData
{
    public static List<string> filepaths;
}
