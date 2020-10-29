using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter),typeof(Mesh))]
public class MeshGeneratorComplex : MonoBehaviour
{
    private Vector3[] _vertices;
    private int[] _triangles;

    Mesh mesh;

    [SerializeField] private float squareSize=0;
    [SerializeField] private int squareCount=0;

    private float [,] heightData;
    [SerializeField] private float heightMultiplier= .75f;

    private float xOffset=0;

    private void Start()
    {
        mesh = GetComponent<MeshFilter>().mesh;

        createHeightData();
        CreatePlaneData();
        CreateMesh();
    }
    private void FixedUpdate()
    {
        CreatePlaneData();
        CreateMesh();
        xOffset += .01f;
        createHeightData();
    }
    private void createHeightData()
    {
        heightData = new float[(squareCount + 1) , (squareCount + 1)]; // vertexlere verilecek
        float vertexDistance = squareSize * 0.5f;

        for (int x = 0; x <= squareCount; x++) 
        {
            for (int z = 0; z <= squareCount; z++)
            {
                float xData = (x * squareSize) * vertexDistance + xOffset; //aşağıdaki gibi almamızın sebebi aynı konumları alıyoruz
                float zData = (z * squareSize) * vertexDistance;
                //float xData = (x * squareSize)  + xOffset;
                //float zData = (z * squareSize);

                 //bu metod parametre olarak koordinat alıyor
                 //heightMultiplier ile çarpmamızın sebebi küsüratlı sayı alması gerek perlinoise metodunun
                heightData[x,z] = Mathf.PerlinNoise(xData * heightMultiplier, zData * heightMultiplier);
            }
        }

    }
    private void CreatePlaneData()
    {
        _vertices = new Vector3[(squareCount + 1) * (squareCount + 1)]; // 3x3 kare için 4x4 nokta sayısı
        _triangles = new int[squareCount * squareCount *6]; //3x3 için 54 üçgen noktası! üçgen 18 tane

        float vertexDistance = squareSize * 0.5f; // 1e1 kare için 0.5f değer çıkar

        int v=0;//vertex aralık vertex = nokta
        int t=0;//triangle aralık

        for (int x = 0; x <= squareCount; x++) //3x3 için 4 kere döner 0 1 2 3 
        {
            for (int z = 0; z <= squareCount; z++)
            {
                //vertexDistance ile çarpıldığı içi 1/4 oranında daha küçük kare oluşturuyor ve ayrıca perlinnoise için 
                _vertices[v] = new Vector3((x * squareSize) * vertexDistance,heightData[x,z],(z * squareSize) * vertexDistance);
                // vertices[0] = new Vector3((0 * 1) * 0.5f) , heightData[0,0] , (0 * 1) * 0.5f)

                /*vertices[0] = (0,..,0),
                  vertices[1] = (0,...,0.5f),
                  vertices[2] = (0,...,1f),
                  vertices[3] = (0,...,1.5f)*/

                //_vertices[v] = new Vector3((x * squareSize),heightData[x,z],(z * squareSize)); // daha az hareket neden?
                v++;
            }
        }

        v=0;

        /*
        3 7 11 15
        2 6 10 14
        1 5 9 13
        0 4 8 12
        */

        //0 1 2 3 4 5 6 7 8 9 10 11 12 13 14 15

        //bir kare oluşturma yeri
        for (int x = 0; x < squareCount; x++) 
        {
            for (int z = 0; z < squareCount; z++)
            {
               _triangles[t + 0] =v; //0
               _triangles[t + 1] =v + 1; //1 
               _triangles[t + 2] =v + (squareCount + 1); // 4
               _triangles[t + 3] =v + (squareCount + 1); // 4
               _triangles[t + 4] =v + 1; //1 
               _triangles[t + 5] =v + (squareCount + 1) + 1; //5
               v++;
               t +=6; 
            }
            v++;
        }

    }
    private void CreateMesh()
    {
       mesh.Clear();

       mesh.vertices = _vertices;
       mesh.triangles = _triangles;

       mesh.RecalculateBounds();
    }
}
  