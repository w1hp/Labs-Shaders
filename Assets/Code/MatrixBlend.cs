using System.Collections;
using UnityEngine;

public class MatrixBlend : MonoBehaviour {
    IEnumerator Start() {
        var mats = GetComponent<MeshRenderer>().materials;
        foreach (var mat in mats) 
            mat.SetFloat("_Blend", 0);
        yield return new WaitForSeconds(Random.Range(0f, 5f));
        var slider = 0f;
        while (slider<1) {
            slider += Time.deltaTime;
            foreach (var mat in mats) 
                mat.SetFloat("_Blend", slider);
            yield return null;
        }
    }
}

// using System.Collections;
// using UnityEngine;

// public class MatrixBlend : MonoBehaviour {
//     IEnumerator Start() {
//         var mats = GetComponent<Renderer>().materials;
//         foreach (var mat in mats) {
//             mat.SetFloat("_Blend", 0);
//         }
//         yield return new WaitForSeconds(Random.Range(0.1f, 5.0f));
//         var slider = 0f;
//         while (slider <= 1) {
//             slider += Time.deltaTime;
//             foreach (var mat in mats) {
//                 mat.SetFloat("_Blend", slider);
//             }
//             yield return null;
//         }
//     }
// }