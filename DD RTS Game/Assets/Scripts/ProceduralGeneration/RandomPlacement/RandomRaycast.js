#pragma strict

public var prefab: Transform;

function Start () {
	
}

function Update () {
	
}

//function GetPointOnMesh() : RaycastHit{
//	var length : float = 100.0;
//	var direction : Vector3 = Random.onUnitSphere;
//	var ray : Ray = Ray(transform.position + direction*length,-direction);
//	var hit : RaycastHit;
//	GetComponent.<Collider>().Raycast (ray, hit, length*2);
//	return hit;
//}

function GetPointOnMesh() : RaycastHit{
    var hit : RaycastHit;
    var mesh : Mesh = GetComponent.<MeshFilter>().mesh;
    var hitTriangleIndex = Random.Range(0,mesh.triangles.Length/3);
    var BC : Vector3;
    BC.x = Random.Range(0.0,1.0);
    BC.y = Random.Range(0.0,1.0-BC.x);
    BC.z = Random.Range(0.0,1.0-BC.x-BC.y);
    hit.barycentricCoordinate = BC;

	var P1 : Vector3 = mesh.vertices[mesh.triangles[hitTriangleIndex + 0]];
	var P2 : Vector3 = mesh.vertices[mesh.triangles[hitTriangleIndex + 1]];
	var P3 : Vector3 = mesh.vertices[mesh.triangles[hitTriangleIndex + 2]];
	hit.point = transform.TransformPoint(P1*BC.x + P2*BC.y + P3*BC.z);

	// Interpolated vertex normal
	var N1 : Vector3 = mesh.normals[mesh.triangles[hitTriangleIndex + 0]];
	var N2 : Vector3 = mesh.normals[mesh.triangles[hitTriangleIndex + 1]];
	var N3 : Vector3 = mesh.normals[mesh.triangles[hitTriangleIndex + 2]];
	hit.normal = N1*BC.x + N2*BC.y + N3*BC.z;

	return hit;

}

function Spawn() {
	var randomPoint = GetPointOnMesh();
	var spawnPreferences = Instantiate(prefab, randomPoint.point, Quaternion.identity);

	if (randomPoint.point.y <= 1.7) {
		return;
	} else {
		spawnPreferences.transform.eulerAngles.y = Random.Range(0, 360);
	}
}
