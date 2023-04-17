<?php

use App\Http\Controllers\DiscountController;
use App\Http\Controllers\LoginController;
use App\Http\Controllers\MasterDataProduct;
use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;

Route::get("/", function () {
  return view("layout.main");
});

Route::prefix("product")->group(function () {
  Route::get("/", [MasterDataProduct::class, 'products'])->name('product');

  Route::post('/add', [MasterDataProduct::class, 'add_products']);

  Route::get('/delete/{kode}', [MasterDataProduct::class, 'delete']);

  Route::post('/delete_selected', [MasterDataProduct::class, 'delete_selected']);

  Route::get('/tags', [MasterDataProduct::class, 'filter_tags']);

  Route::get('/search', [MasterDataProduct::class, 'filter_search'])->name('search_product');

  Route::get('/kategori', [MasterDataProduct::class, 'filter_kategori']);

  Route::post('/update', [MasterDataProduct::class, 'update_product']);

  Route::get('/tag/delete/{kode}', [MasterDataProduct::class, 'delete_tag']);

  Route::post('/tag/add', [MasterDataProduct::class, 'tambah_tag']);
});

//apabila belum login atau statusnya belum auth secara otomatis akan terlempar ke home, path home sendiri diatur pada App/Providers/RouteServiceProvider.php baris 20
Route::get("/login", [LoginController::class, 'index'])->name('login')->middleware('guest');

Route::post("/login", [LoginController::class, 'checkLogin']);
Route::post("/logout", [LoginController::class, 'logout']);

// Route::get("/register", function () {
//   return view('front_view.register');
// });
// Route::post("/register", [LoginController::class, 'registerhahai'])->middleware('guest');

Route::prefix("laporan")->group(function () {
  Route::get("/pemasukan", function () {
    return view("report.pemasukan");
  })->middleware('auth');
});

Route::get("/retur", function () {
  return view("retur.retur");
});

Route::get("/landing", function () {
  return view("layout.landing_main");
});

Route::get('/riwayat', function () {
  return view('riwayat.riwayat');
});

Route::get('/diskon', [DiscountController::class, 'index']);

Route::post('/diskon/add', [DiscountController::class, "tambah_diskon"]);

Route::post('/diskon/update', [DiscountController::class, "update_diskon"]);

Route::post('/diskon/delete_selected', [DiscountController::class, "delete_selected"]);

Route::get('/diskon/delete/{kode}', [DiscountController::class, 'delete']);

Route::get('/diskon/kategori', [DiscountController::class, 'filter_kategori']);

Route::get('/diskon/search', [DiscountController::class, 'filter_search']);
