@extends('layout.main')

@section('othercss')
@endsection

@section('modal')
    @include('modal.add_pengeluaran_operasional')
    @include('modal.filterDate.filter')
@endsection

@section('title')
    Pengeluaran
@endsection

@section('content')
    {{-- content --}}
    <div class="flex flex-col w-full">

        {{-- top1 --}}
        <div
            class="flex flex-row w-full items-center justify-center md:h-16 bg-white text-[11px] md:text-[15px] border-b-[1px] border-b-[#DCDADA]">

            {{-- left --}}
            <div
                class="flex items-center relative justify-between gap-2 md:gap-4 w-full md:w-[30%] px-3 min-[374px]:px-5 md:px-7 h-11 min-[360px]:h-14 md:h-full">

                {{-- menu --}}
                <div id="menuLaporan" class="md:hidden poppins-medium cursor-pointer flex h-full items-center gap-2">
                    <p class="text-selector-none">Pengeluaran</p>
                    <div id="arrowMenu" class="rotate-180 transition ease-in-out delay-75">

                        <svg class="w-[11px] h-[5px]" viewBox="0 0 59 30" fill="none" xmlns="http://www.w3.org/2000/svg">
                            <path
                                d="M29.5 0.499999C30.1936 0.499999 30.8646 0.610691 31.5131 0.832065C32.1651 1.05344 32.7078 1.3486 33.1413 1.71756L57.0695 22.084C58.0232 22.8957 58.5 23.9288 58.5 25.1832C58.5 26.4377 58.0232 27.4707 57.0695 28.2824C56.1158 29.0941 54.9021 29.5 53.4283 29.5C51.9544 29.5 50.7407 29.0941 49.787 28.2824L29.5 11.0153L9.21301 28.2824C8.25935 29.0941 7.04559 29.5 5.57175 29.5C4.09791 29.5 2.88417 29.0941 1.93051 28.2824C0.976843 27.4707 0.500002 26.4377 0.500002 25.1832C0.500002 23.9288 0.976843 22.8957 1.93051 22.084L25.8587 1.71756C26.3789 1.27481 26.9425 0.961936 27.5493 0.778934C28.1562 0.59298 28.8064 0.499999 29.5 0.499999Z"
                                fill="black" />
                        </svg>
                    </div>
                </div>

                {{-- dropdown --}}
                <div id="menuDropDown"
                    class=" max-md:shadow-md text-selector-none flex flex-col md:flex-row md:items-end max-md:hidden max-md:absolute gap-2 min-[360px]:gap-3 md:gap-5 poppins-medium text-[#2c2c2c] p-2 min-[360px]:p-3 md:p-0 w-24 min-[360px]:w-32 md:w-auto rounded-sm min-[360px]:rounded-[5px] bg-white top-8 min-[360px]:top-10 max-md:border-[1px] max-md:border-[#DCDADA] md:h-full">
                    <a id="menu_pemasukan1" href="{{ route('operasional') }}"
                        class="text-[#ff9215] md:relative transition ease-in-out flex items-center h-full">
                        <p>Operasional</p>
                        <div class="max-md:hidden absolute bottom-0 w-full h-[6px] bg-[#FFB015]">
                        </div>
                    </a>
                    <a id="menu_pemasukan2" href=""
                        class="hover:text-[#ff9215] md:relative transition ease-in-out flex items-center h-full">
                        <p class="whitespace-nowrap">Re-Stock</p>
                        <div class="max-md:hidden absolute bottom-0 w-full h-[6px] transition ease-in-out">
                        </div>
                    </a>
                </div>

            </div>

            {{-- right --}}
            <div class="flex h-11 min-[360px]:h-14 md:h-full justify-end items-center w-full px-3 min-[374px]:px-5 md:px-7">

                <button type="button" onclick="showModal()"
                    class="flex justify-between items-center gap-2 py-1 px-2 md:py-2 md:px-3 rounded-md transition ease-in-out bg-[#FFB015] hover:bg-[#e69900] shadow-md">

                    <p class="poppins-medium">Tambah Data</p>

                    <svg class="w-[10px] aspect-square" viewBox="0 0 15 15" fill="none"
                        xmlns="http://www.w3.org/2000/svg">
                        <path fill-rule="evenodd" clip-rule="evenodd"
                            d="M0.497057 7.69726C0.497055 8.36001 1.03432 8.89727 1.69706 8.89727L6.49706 8.89727L6.49706 13.6973C6.49706 14.36 7.03432 14.8973 7.69704 14.8972C8.35977 14.8972 8.89702 14.36 8.89704 13.6973L8.89706 8.89726L13.697 8.89725C14.3598 8.8972 14.8971 8.35994 14.8971 7.69724C14.8971 7.03454 14.3598 6.49728 13.6971 6.49725L8.89705 6.49727L8.89707 1.69726C8.89705 1.03454 8.35979 0.497276 7.69707 0.497254C7.03435 0.497235 6.49709 1.0345 6.49706 1.69726L6.49706 6.49726L1.69705 6.49727C1.03431 6.49727 0.497059 7.03452 0.497057 7.69726Z"
                            fill="black" />
                    </svg>

                </button>
            </div>

        </div>

        {{-- top2 --}}
        <div
            class="flex flex-row justify-between w-full items-center h-11 min-[360px]:h-[54px] md:h-16 bg-white text-[11px] md:text-[15px] border-b-[1px] border-b-[#DCDADA]">

            {{-- search --}}
            <div class="flex items-center gap-2 w-1/2 h-full px-3 min-[374px]:px-5 md:px-7">
                <svg class="w-[15px] h-[16px] md:w-[20px] md:h-[21px]" viewBox="0 0 25 26" fill="none"
                    xmlns="http://www.w3.org/2000/svg">
                    <path
                        d="M11.1158 19.7364C15.9969 19.7364 19.9538 15.8248 19.9538 10.9995C19.9538 6.17431 15.9969 2.2627 11.1158 2.2627C6.23472 2.2627 2.27783 6.17431 2.27783 10.9995C2.27783 15.8248 6.23472 19.7364 11.1158 19.7364Z"
                        fill="white" stroke="black" stroke-width="3" />
                    <path d="M17.3374 17.7676L23.0022 24.1676" stroke="black" stroke-width="3" />
                </svg>
                <form action="{{ url('pengeluaran/operasional') }}" method="GET" id="form_search">
                    <input type="search" id="field_search" name="search" value="{{ $dataUrl['search'] }}"
                        class="placeholder:text-[11px] md:placeholder:text-[15px] outline-none w-[80%]"
                        placeholder="Kode transaksi" value="">
                </form>
            </div>

            {{-- expor, filter --}}
            <div class="flex items-center justify-end gap-2 md:gap-3 w-1/2 h-full px-3 min-[374px]:px-5 md:px-7">

                {{-- export --}}
                <button type="button"
                    class="flex items-center gap-2 transition ease-in-out bg-black hover:bg-[#292929] p-2 md:px-3 rounded-md shadow-md">

                    <p class="poppins-medium max-md:hidden text-white">Export</p>


                    <svg class="w-[13px] md:w-[16px] aspect-square fill-white" viewBox="0 0 22 22"
                        xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M17.6414 8.25756L17.6415 8.25755L17.6407 8.2547C17.3756 7.21195 16.8366 6.26304 16.0753 5.50223L13.1732 2.60223C12.0442 1.47412 10.5384 0.85 8.93912 0.85H5.16971C2.78529 0.85 0.85 2.78372 0.85 5.16667V16.8333C0.85 19.2163 2.78529 21.15 5.16971 21.15H13.5091C14.7446 21.15 15.9276 20.615 16.7481 19.6917C17.1123 19.288 17.0733 18.6591 16.6604 18.304C16.2562 17.9409 15.6272 17.9803 15.2722 18.3933C14.8254 18.9021 14.183 19.1917 13.5091 19.1917H5.16971C3.87644 19.1917 2.81788 18.1337 2.81788 16.8417V5.16667C2.81788 3.87461 3.87644 2.81667 5.16971 2.81667H8.93078C9.01888 2.81667 9.10571 2.81675 9.18941 2.82104V6.83333C9.18941 8.29128 10.3825 9.48333 11.8412 9.48333H16.6864C16.9908 9.48333 17.2772 9.34554 17.4646 9.09914C17.6512 8.85384 17.7096 8.54937 17.6414 8.25756ZM20.3951 16.1811L20.395 16.1811C21.404 15.1555 21.402 13.5001 20.3868 12.4856L19.0441 11.1439C18.6603 10.7604 18.04 10.7604 17.6562 11.1439C17.2723 11.5275 17.2723 12.1475 17.6562 12.5311L18.4757 13.35H12.6668C12.1254 13.35 11.6829 13.7921 11.6829 14.3333C11.6829 14.8746 12.1254 15.3167 12.6668 15.3167H18.4757L17.6562 16.1356C17.2723 16.5191 17.2723 17.1392 17.6562 17.5228L17.6562 17.5228L17.6589 17.5255C17.8527 17.7094 18.0978 17.8083 18.3543 17.8083C18.6074 17.8083 18.8551 17.7199 19.0524 17.5228L20.3868 16.1894L20.3872 16.189L20.3951 16.1811ZM11.149 6.83333V3.48136C11.3719 3.63014 11.5812 3.80221 11.7769 3.99777L14.679 6.89777C14.8657 7.08428 15.0348 7.29397 15.1826 7.51667H11.8329C11.457 7.51667 11.149 7.20872 11.149 6.83333Z"
                            fill="white" stroke="white" stroke-width="0.3" />
                    </svg>

                </button>

                {{-- filter --}}
                <button type="button" onclick="showModalFilter()"
                    class="flex items-center gap-2 transition ease-in-out bg-[#FFB015] hover:bg-[#e69900] p-2 md:px-3 rounded-md shadow-md">

                    <p class="poppins-medium max-md:hidden">Filter</p>

                    <svg class="w-[13px] md:w-[16px] aspect-square fill-black" viewBox="0 0 20 20"
                        xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M1.69335 5.80967L1.69349 5.80982L7.39553 11.9414V16.2791C7.39553 16.425 7.43109 16.5686 7.49903 16.6985C7.56694 16.8283 7.66521 16.9406 7.78552 17.0268L11.0593 19.3738C11.2269 19.4939 11.4298 19.5583 11.6378 19.5583C11.8925 19.5583 12.138 19.4617 12.3201 19.2876C12.5024 19.1134 12.6062 18.8755 12.6062 18.626V11.9414L18.3058 5.81059L18.3059 5.81049C18.7336 5.3496 19.0137 4.77966 19.1114 4.1689C19.2092 3.55811 19.1202 2.93349 18.8557 2.37038C18.5913 1.80735 18.1628 1.33034 17.6229 0.995887C17.083 0.661472 16.4542 0.483533 15.812 0.482812H15.8118L4.18992 0.482812L4.18983 0.482813C3.54756 0.4832 2.9186 0.660845 2.37849 0.995035C1.83833 1.32926 1.40962 1.80612 1.14487 2.36909C0.880087 2.93214 0.790882 3.55677 0.888393 4.16766C0.985898 4.77851 1.26577 5.3486 1.69335 5.80967ZM10.6693 11.5851V11.5852V16.7693L9.33242 15.8109V11.5852C9.33242 11.5852 9.33242 11.5852 9.33242 11.5852C9.33248 11.355 9.2442 11.134 9.08611 10.9637L9.08602 10.9636L3.13706 4.56617C3.13701 4.56612 3.13696 4.56606 3.13692 4.56601C2.95862 4.37306 2.84301 4.13584 2.80293 3.88305C2.76285 3.63024 2.79985 3.37156 2.90989 3.13779C3.01998 2.90394 3.1988 2.70437 3.42588 2.56379C3.65299 2.42319 3.91834 2.34785 4.19005 2.34744C4.19008 2.34744 4.19011 2.34744 4.19013 2.34744L15.8117 2.34744C16.0835 2.34771 16.3491 2.42301 16.5764 2.56366C16.8036 2.70428 16.9825 2.90395 17.0926 3.13794L17.2283 3.07406L17.0926 3.13794C17.2027 3.37184 17.2396 3.63066 17.1994 3.88359C17.1592 4.13648 17.0434 4.37374 16.8649 4.56667C16.8649 4.56674 16.8648 4.5668 16.8647 4.56687L10.9166 10.9635C10.9166 10.9635 10.9165 10.9636 10.9165 10.9636C10.7581 11.1338 10.6695 11.3548 10.6693 11.5851Z"
                            stroke-width="0.3" />
                    </svg>

                </button>

                {{-- reset --}}
                <a href="{{ route('operasional') }}">
                    <svg class="cursor-pointer w-[15px] md:w-[20px] aspect-square" viewBox="0 0 30 30" fill="none"
                        xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M5.96667 3.76616V0.849609V0.549609H5.66667H3.33333H3.03333V0.849609V6.68294C3.03333 8.13546 4.21415 9.31628 5.66667 9.31628H11.5H11.8V9.01628V6.68294V6.38294H11.5H7.41874C9.48385 4.53668 12.1784 3.48294 15 3.48294C21.2673 3.48294 26.3667 8.58229 26.3667 14.8496C26.3667 21.1169 21.2673 26.2163 15 26.2163C8.73269 26.2163 3.63333 21.1169 3.63333 14.8496V14.5496H3.33333H1H0.7V14.8496C0.7 22.7351 7.11448 29.1496 15 29.1496C22.8855 29.1496 29.3 22.7351 29.3 14.8496C29.3 6.96409 22.8855 0.549609 15 0.549609C11.6744 0.549609 8.49055 1.7121 5.96667 3.76616Z"
                            fill="#787777" stroke="#787777" stroke-width="0.6" />
                    </svg>
                </a>
            </div>

        </div>

        {{-- content --}}
        <div class="flex flex-col w-full lg:justify-between p-2 lg:h-[65vh] xl:h-[63vh] 2xl:h-[70vh]">
            @if (count($finalDataPengeluaran->items()) != 0)
                {{-- table --}}
                <div class="w-full overflow-auto whitespace-nowrap text-ellipsis mt-3 md:mt-6 lg:mt-3">
                    <table class=" w-full border-separate border-spacing-y-4 text-[11px] md:text-[15px] px-2">
                        <thead>
                            <tr>
                                <th class="text-center text-[#787777]">Kode Transaksi</th>
                                <th class="text-center text-[#787777]">Tgl</th>
                                <th class="text-center text-[#787777]">User</th>
                                <th class="text-center text-[#787777]">Keterangan</th>
                                <th class="text-center text-[#787777]">Total</th>
                                <th class="text-center text-[#787777]">Aksi</th>
                            </tr>
                        </thead>
                        <tbody>
                            @foreach ($finalDataPengeluaran as $data)
                                <tr class="bg-white border-2 outline outline-[1px] outline-[#DCDADA] rounded-md">
                                    <td class="text-center p-3">{{ $data->kode_pengeluaran }}</td>
                                    <td class="text-center p-3">{{ $data->tanggal }}</td>
                                    <td class="text-center p-3">@if ($data->pengeluaran_pegawai !== null)
                                      {{ $data->pengeluaran_pegawai->pegawai->nama }}
                                    @else
                                      -
                                    @endif</td>
                                    <td class="text-center p-3">{{ $data->item_operasional }}</td>
                                    <td class="text-center p-3">{{ rupiah($data->total) }}</td>
                                    <td class="text-center p-3">
                                        <svg onclick=""
                                            class="cursor-pointer w-[30px] h-[30px] md:w-[50px] md:h-[50px] lg:w-[40px] lg:h-[40px] m-auto"
                                            viewBox="0 0 54 54" fill="none" xmlns="http://www.w3.org/2000/svg">
                                            <g filter="url(#filter0_d_653_130)">
                                                <rect x="2" y="4" width="46" height="46"
                                                    rx="6" fill="#FFB015" />
                                            </g>
                                            <path
                                                d="M28.875 24.75C25.4975 24.75 22.75 27.4975 22.75 30.875C22.75 34.2525 25.4975 37 28.875 37C32.2525 37 35 34.2525 35 30.875C35 27.4975 32.2525 24.75 28.875 24.75ZM28.875 35.25C26.46 35.25 24.5 33.29 24.5 30.875C24.5 28.46 26.46 26.5 28.875 26.5C31.29 26.5 33.25 28.46 33.25 30.875C33.25 33.29 31.29 35.25 28.875 35.25ZM30.1875 28.6875C30.1875 29.4137 29.6012 30 28.875 30C28.1488 30 27.5625 29.4137 27.5625 28.6875C27.5625 27.9613 28.1488 27.375 28.875 27.375C29.6012 27.375 30.1875 27.9613 30.1875 28.6875ZM29.75 31.75V33.5C29.75 33.9813 29.3562 34.375 28.875 34.375C28.3938 34.375 28 33.9813 28 33.5V31.75C28 31.2688 28.3938 30.875 28.875 30.875C29.3562 30.875 29.75 31.2688 29.75 31.75ZM21.875 34.375C21.875 34.8563 21.4812 35.25 21 35.25H18.375C15.96 35.25 14 33.29 14 30.875V20.375C14 17.96 15.96 16 18.375 16H23.415C24.3337 16 25.235 16.3762 25.8913 17.0237L28.7262 19.8587C29.3125 20.445 29.6712 21.2237 29.7413 22.0462C29.7762 22.5275 29.4175 22.9475 28.9362 22.9913C28.91 22.9913 28.8925 22.9913 28.8663 22.9913C28.4113 22.9913 28.035 22.6413 27.9913 22.1863C27.9913 22.16 27.9913 22.1425 27.9913 22.1163H25.3837C24.4213 22.1163 23.6337 21.3287 23.6337 20.3663V17.7675C23.5638 17.7675 23.4938 17.75 23.4237 17.75H18.375C16.9313 17.75 15.75 18.9313 15.75 20.375V30.875C15.75 32.3188 16.9313 33.5 18.375 33.5H21C21.4812 33.5 21.875 33.8937 21.875 34.375Z"
                                                fill="black" />
                                            <defs>
                                                <filter id="filter0_d_653_130" x="0" y="0"
                                                    width="54" height="54" filterUnits="userSpaceOnUse"
                                                    color-interpolation-filters="sRGB">
                                                    <feFlood flood-opacity="0" result="BackgroundImageFix" />
                                                    <feColorMatrix in="SourceAlpha" type="matrix"
                                                        values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 127 0"
                                                        result="hardAlpha" />
                                                    <feOffset dx="2" />
                                                    <feGaussianBlur stdDeviation="2" />
                                                    <feComposite in2="hardAlpha" operator="out" />
                                                    <feColorMatrix type="matrix"
                                                        values="0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0 0.22 0" />
                                                    <feBlend mode="normal" in2="BackgroundImageFix"
                                                        result="effect1_dropShadow_653_130" />
                                                    <feBlend mode="normal" in="SourceGraphic"
                                                        in2="effect1_dropShadow_653_130" result="shape" />
                                                </filter>
                                            </defs>
                                        </svg>
                                    </td>
                                </tr>
                            @endforeach



                        </tbody>

                    </table>
                </div>

                {{-- bottom --}}
                <div
                    class="flex flex-col lg:flex-row lg:justify-between lg:px-[3%] items-center w-full text-[11px] md:text-[15px] gap-3 md:gap-5 lg:gap-0 mt-5 lg:mt-3">
                    {{ $finalDataPengeluaran->onEachSide(2)->links('vendor.pagination.CustomPagination') }}
                </div>
            @else
                <div class="flex items-center w-full h-full">
                    <div class="flex flex-col items-center w-full">
                        <img class="object-cover w-[90%] lg:w-[40%]" src="{{ asset('/assets/images/nodata.svg') }}"
                            alt="nodata">
                        <p class="text-2xl poppins-semibold">No Data</p>
                    </div>
                </div>
            @endif
        </div>


    </div>
@endsection

@section('otherjs')
    @include('modal.filterDate.controller')
    <script src="{{ asset('js/controllers/pengeluaran_operasional.js') }}"></script>

    @if ($errors->any())
        <script>
            showModal()
        </script>
    @endif
@endsection