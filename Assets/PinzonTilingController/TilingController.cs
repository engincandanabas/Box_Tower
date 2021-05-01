// Pinzon Games© All Rights Reserved

using UnityEngine;
using System.Collections;

[ExecuteInEditMode]
public class TilingController : MonoBehaviour {

    [ReadOnly]
	[Tooltip("Objeye material koymamanız sizin için daha iyi olucaktır, Default material ile devam edebilirsiniz. Materialin tiling değerlerini objenizin boyutu ile otomatik olarak ayarlamak için script üzerine sağ tık yaparak en alttan Tiling Güncelle seçeneğini seçerek tiling değerlerinin otomatik olarak eşitlenmesini sağlayabilirsiniz. Daha fazla bilgi için imlecinizi değişkenlerin üzerine getirebilirsiniz.")]
	public string bilgi = "İmleci 'Bilgi' nin üzerine getir.";

    [Tooltip("Texture resminizi buraya sürükleyip bırakmanız gerekiyor. Bu resmi, boyutlarını alıp tiling değerlerini değiştirmek için kullanılıcak.")]
    public Texture texture;

    [Tooltip("Texture boyutunuzu değiştirmek için kullanabilirsiniz. Texture nizde bir sıkıntı görmediğiniz sürece değiştirmeniz önerilmez.")]
    public float textureToMeshZ = 2f;

    Vector3 prevScale = Vector3.one;
    float prevTextureToMeshZ = -1f;

    void Start () {
        this.prevScale = gameObject.transform.lossyScale;
        this.prevTextureToMeshZ = this.textureToMeshZ;

        this.UpdateTiling();
    }

    void Update () {
        // Eğer bir değişiklik olduysa tekrardan tiling değerlerini ayarla.
        if(gameObject.transform.lossyScale != prevScale || !Mathf.Approximately(this.textureToMeshZ, prevTextureToMeshZ))
            this.UpdateTiling();

        // Eski state'in değişkenleri
        this.prevScale = gameObject.transform.lossyScale;
        this.prevTextureToMeshZ = this.textureToMeshZ;
    }

    [ContextMenu("Tiling Güncelle")]
    void UpdateTiling()
    {
        // Default Unity Plane boyutları
        float planeSizeX = 10f;
        float planeSizeZ = 10f;

        float textureToMeshX = ((float)this.texture.width/this.texture.height)*this.textureToMeshZ;

        gameObject.GetComponent<Renderer>().material.mainTextureScale = new Vector2(planeSizeX*gameObject.transform.lossyScale.x/textureToMeshX, planeSizeZ*gameObject.transform.lossyScale.z/textureToMeshZ);
    }
}