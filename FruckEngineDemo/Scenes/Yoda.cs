﻿using System.Collections.Generic;
using FruckEngine.Graphics;
using FruckEngine.Helpers;
using FruckEngine.Objects;
using OpenTK;
using FruckEngine.Game;

namespace FruckEngineDemo.Scenes {
    public class Yoda : Scene {
        protected override void Init(World world) {
            world.Environment.AmbientLight = Vector3.One;
            //world.Environment.Sun.Position = new Vector3(-0.2962257f, 0.5735765f, -0.7637148f);
            world.Environment.Sun.Position = new Vector3(-0.6794168f, 0.7181264f, 0.1506226f);
            world.Environment.Sun.Intensity = 0;
            
            
            var env = TextureHelper.LoadCubemapFromDir("Assets/cubemaps/Swamp", 10000);
            world.Environment.SetTexture(env, true);
            
            world.MainCamera.Position = new Vector3(0, 0, 15);
            world.MainCamera.SetRotation(0, -180);
            
            const string directory = "Assets/models/yoda";
            var model = AssimpLoadHelper.LoadModel(directory + "/Yoda Bust.OBJ", true);
            var material = model.Meshes[0].AsPBR();
            material.Albedo = Vector3.One;
            material.Metallic = 0.4f;
            material.Roughness = 0.7f;
            model.Scale = Vector3.One * 0.4f;
            world.AddObject(model);
            
            world.AddLight(new PointLight(  new Vector3(-20.0f, 50.0f, -45.0f), new Vector3(1.0342f, 1.0759f, 0.3f), 100000));
            world.AddLight(new PointLight(  new Vector3(-20.0f, 50.0f, 45.0f), Vector3.One, 10000));

           
        }
    }
}