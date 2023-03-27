

$("#btn_tambah").click(function (e) {
    e.preventDefault();
    showModal();
});

$("#bg_modal").click(function (e) {
    e.preventDefault();
    closeModal();
});

$("#btn_hapus").click(function (e) { 
    e.preventDefault();
    location.href = '/filtertags/' + selectedTags.toString().replace(',', '&');
    // $("#form_filter").trigger("submit");
});

function ubahData(nama, warna, kategori, ukuran, harga, tags) {
    $("#button_submit").html("Ubah Data");
    $("#title_modal").html("Ubah Data");

    $("#txt_nama").val(nama);
    $("#txt_warna").val(warna);
    $("#txt_kategori").val(kategori);
    $("#txt_ukuran").val(ukuran);
    $("#txt_harga").val(harga);
    var tags_selected = JSON.parse(tags);
    console.log(tags_selected);
    for (let index = 0; index < tags_selected.length; index++) {
        const element = tags_selected[index];
        $("#" + element.kode_tag).attr("checked", true);
        // console.log(element.kode_tag);
    }
    showModal();
}

var selectedTags = [];

function filterTags(kode) {
    if ($("#" + kode).hasClass("bg-[#FFB015]")) {
        for (let index = 0; index < selectedTags.length; index++) {
            const element = selectedTags[index];
            if (element == kode) {
                removeItemOnce(selectedTags, kode);
            }
        }
    } else {
        selectedTags.push(kode);
    }

    $("#" + kode).toggleClass(
        "bg-white border-[#D9D9D9] text-[#9B9B9B]"
    );

    $("#" + kode).toggleClass(
        "bg-[#FFB015] border-[#FFB015] text-black poppins-medium"
    );
    console.log(selectedTags);
}

function removeItemOnce(arr, value) {
    var index = arr.indexOf(value);
    if (index > -1) {
        arr.splice(index, 1);
    }
    return arr;
}

function resetForm() {
    $("#button_submit").html("Tambah Data");
    $("#title_modal").html("Tambah Data");
    $('input[type="checkbox"]').attr("checked", false);

    $("#form_product").trigger("reset");
}

function showModal() {
    $("#bg_modal").removeClass("pointer-events-none");
    $("#bg_modal").addClass("opacity-50");
    $("#bg_modal").removeClass("opacity-0");

    $("#konten_modal").addClass("scale-100");
    $("#konten_modal").removeClass("scale-0");
}

function closeModal() {
    $("#bg_modal").addClass("pointer-events-none");
    $("#bg_modal").removeClass("opacity-50");
    $("#bg_modal").addClass("opacity-0");

    $("#konten_modal").removeClass("scale-100");
    $("#konten_modal").addClass("scale-0");

    resetForm();
}

$("#btn_submit").submit(function (e) {
    e.preventDefault();
    console.log("wdakdoawkdowa");
});
