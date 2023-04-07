@extends('layout.main')

@section('title')
    Laporan Pemasukan
@endsection

@section('content')
    {{-- container --}}
    <div class="flex flex-col w-full h-full lg:h-[85vh] xl:h-[88vh]">

        {{-- top --}}
        <div
            class="flex justify-between items-center relative w-full px-5 md:px-[30px] gap-4 h-11 min-[360px]:h-14 md:h-16 2xl:h-24 bg-white text-[12px] md:text-[15px] border-b-[1px] border-b-[#DCDADA]">

            {{-- left --}}

            {{-- menu --}}
            <div id="menuLaporan" class="md:hidden poppins-medium cursor-pointer flex h-full items-center gap-2">
                <p class="text-selector-none">Pemasukan</p>
                <div id="arrowMenu" class="transition ease-in-out delay-75">
                    <svg class="w-[11px] h-[5px]" viewBox="0 0 14 8" fill="none" xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M7 8C6.83259 8 6.67061 7.96946 6.51408 7.9084C6.35671 7.84733 6.22571 7.7659 6.12108 7.66412L0.345291 2.0458C0.115097 1.82188 0 1.53689 0 1.19084C0 0.844783 0.115097 0.559796 0.345291 0.335877C0.575485 0.111959 0.86846 0 1.22421 0C1.57997 0 1.87294 0.111959 2.10314 0.335877L7 5.09924L11.8969 0.335877C12.1271 0.111959 12.42 0 12.7758 0C13.1315 0 13.4245 0.111959 13.6547 0.335877C13.8849 0.559796 14 0.844783 14 1.19084C14 1.53689 13.8849 1.82188 13.6547 2.0458L7.87892 7.66412C7.75336 7.78626 7.61734 7.87257 7.47085 7.92305C7.32436 7.97435 7.16741 8 7 8Z"
                            fill="black" />
                    </svg>
                </div>
            </div>

            {{-- dropdown --}}
            <div id="menuDropDown"
                class=" max-md:shadow-md text-selector-none flex flex-col md:flex-row md:items-end max-md:hidden max-md:absolute gap-2 min-[360px]:gap-3 md:gap-5 poppins-medium text-[#2c2c2c] p-2 min-[360px]:p-3 md:p-0 w-24 min-[360px]:w-32 md:w-auto rounded-sm min-[360px]:rounded-[5px] bg-white top-8 min-[360px]:top-10 max-md:border-[1px] max-md:border-[#DCDADA] md:h-full">
                <a id="menu_pemasukan1" href="#"
                    class="text-[#ff9215] md:relative transition ease-in-out flex items-center h-full">
                    <p>Pemasukan</p>
                    <div class="max-md:hidden absolute bottom-0 w-full h-[6px] bg-[#FFB015]">
                    </div>
                </a>
                <a id="menu_pemasukan2" href="#"
                    class="hover:text-[#ff9215] md:relative transition ease-in-out flex items-center h-full">
                    <p>Pengeluaran</p>
                    <div class="max-md:hidden absolute bottom-0 w-full h-[6px] transition ease-in-out">
                    </div>
                </a>
                <a id="menu_pemasukan3" href="#"
                    class="hover:text-[#ff9215] md:relative transition ease-in-out flex items-center h-full">
                    <p>Retur</p>
                    <div class="max-md:hidden absolute bottom-0 w-full h-[6px] transition ease-in-out">
                    </div>
                </a>
            </div>

            {{-- end left --}}

            {{-- right --}}
            <div class="flex poppins-medium gap-2">

                {{-- filter --}}
                <button
                    class="text-selector-none flex items-center gap-2 py-2 px-3 md:py-2 md:px-3 rounded-md shadow-lg bg-[#FFB015] hover:bg-[#d48e00] transition ease-in-out">
                    <p>Filter</p>
                    <svg class="w-[17px] h-[15px] md:w-[20px] md:h-[18px]" viewBox="0 0 24 26" fill="none"
                        xmlns="http://www.w3.org/2000/svg">
                        <mask id="path-1-outside-1_233_13" maskUnits="userSpaceOnUse" x="0" y="0"
                            width="24" height="26" fill="black">
                            <rect fill="white" width="24" height="26" />
                            <path fill-rule="evenodd" clip-rule="evenodd"
                                d="M13.4017 24.8C13.5748 24.9298 13.7854 25 14.0019 25C14.2672 25 14.5216 24.8946 14.7092 24.7071C14.8968 24.5196 15.0022 24.2652 15.0022 24V15.38L22.0174 7.488C22.516 6.9261 22.8417 6.23222 22.9553 5.48975C23.0689 4.74727 22.9657 3.9878 22.6579 3.30259C22.3502 2.61737 21.851 2.03557 21.2205 1.62711C20.59 1.21864 19.8549 1.00088 19.1035 1H4.89897C4.14755 1.00047 3.41226 1.21787 2.78147 1.62607C2.15068 2.03426 1.65123 2.61588 1.34315 3.30101C1.03507 3.98615 0.931478 4.74565 1.04481 5.48823C1.15815 6.23082 1.48359 6.92488 1.98203 7.487L9.00028 15.38V21C9.00028 21.1552 9.03643 21.3084 9.10588 21.4472C9.17533 21.5861 9.27617 21.7069 9.4004 21.8L13.4017 24.8ZM13.0016 22L11.0009 20.5V15C11.001 14.7553 10.9113 14.519 10.7488 14.336L3.47751 6.158C3.2354 5.88405 3.07748 5.5461 3.02269 5.18468C2.9679 4.82326 3.01857 4.45371 3.16862 4.12035C3.31867 3.78699 3.56173 3.50399 3.86864 3.30527C4.17556 3.10655 4.5333 3.00055 4.89897 3H19.1035C19.4694 3.00038 19.8273 3.10632 20.1344 3.30509C20.4415 3.50386 20.6847 3.78701 20.8348 4.12056C20.9849 4.4541 21.0355 4.82387 20.9805 5.18545C20.9256 5.54704 20.7674 5.88508 20.525 6.159L13.2546 14.336C13.0918 14.5189 13.0018 14.7552 13.0016 15V22Z" />
                        </mask>
                        <path fill-rule="evenodd" clip-rule="evenodd"
                            d="M13.4017 24.8C13.5748 24.9298 13.7854 25 14.0019 25C14.2672 25 14.5216 24.8946 14.7092 24.7071C14.8968 24.5196 15.0022 24.2652 15.0022 24V15.38L22.0174 7.488C22.516 6.9261 22.8417 6.23222 22.9553 5.48975C23.0689 4.74727 22.9657 3.9878 22.6579 3.30259C22.3502 2.61737 21.851 2.03557 21.2205 1.62711C20.59 1.21864 19.8549 1.00088 19.1035 1H4.89897C4.14755 1.00047 3.41226 1.21787 2.78147 1.62607C2.15068 2.03426 1.65123 2.61588 1.34315 3.30101C1.03507 3.98615 0.931478 4.74565 1.04481 5.48823C1.15815 6.23082 1.48359 6.92488 1.98203 7.487L9.00028 15.38V21C9.00028 21.1552 9.03643 21.3084 9.10588 21.4472C9.17533 21.5861 9.27617 21.7069 9.4004 21.8L13.4017 24.8ZM13.0016 22L11.0009 20.5V15C11.001 14.7553 10.9113 14.519 10.7488 14.336L3.47751 6.158C3.2354 5.88405 3.07748 5.5461 3.02269 5.18468C2.9679 4.82326 3.01857 4.45371 3.16862 4.12035C3.31867 3.78699 3.56173 3.50399 3.86864 3.30527C4.17556 3.10655 4.5333 3.00055 4.89897 3H19.1035C19.4694 3.00038 19.8273 3.10632 20.1344 3.30509C20.4415 3.50386 20.6847 3.78701 20.8348 4.12056C20.9849 4.4541 21.0355 4.82387 20.9805 5.18545C20.9256 5.54704 20.7674 5.88508 20.525 6.159L13.2546 14.336C13.0918 14.5189 13.0018 14.7552 13.0016 15V22Z"
                            fill="black" />
                        <path
                            d="M13.4017 24.8L13.5816 24.56L13.5816 24.56L13.4017 24.8ZM15.0022 15.38L14.778 15.1807L14.7022 15.2659V15.38H15.0022ZM22.0174 7.488L22.2417 7.68731L22.2418 7.68711L22.0174 7.488ZM22.9553 5.48975L22.6588 5.44437L22.6588 5.44437L22.9553 5.48975ZM22.6579 3.30259L22.9316 3.17968L22.9316 3.17967L22.6579 3.30259ZM21.2205 1.62711L21.3836 1.37532L21.3836 1.37532L21.2205 1.62711ZM19.1035 1L19.1039 0.7H19.1035V1ZM4.89897 1L4.89897 0.7L4.89878 0.7L4.89897 1ZM2.78147 1.62607L2.94445 1.87793L2.94445 1.87793L2.78147 1.62607ZM1.34315 3.30101L1.61676 3.42405L1.61676 3.42405L1.34315 3.30101ZM1.04481 5.48823L1.34138 5.44297L1.34138 5.44297L1.04481 5.48823ZM1.98203 7.487L1.75757 7.68604L1.75784 7.68634L1.98203 7.487ZM9.00028 15.38H9.30028V15.2659L9.22447 15.1807L9.00028 15.38ZM9.10588 21.4472L9.3742 21.313L9.3742 21.313L9.10588 21.4472ZM9.4004 21.8L9.22044 22.04L9.22044 22.04L9.4004 21.8ZM11.0009 20.5H10.7009V20.65L10.821 20.74L11.0009 20.5ZM13.0016 22L12.8216 22.24L13.3016 22.5999V22H13.0016ZM11.0009 15L10.7009 14.9999V15H11.0009ZM10.7488 14.336L10.9732 14.1369L10.973 14.1367L10.7488 14.336ZM3.47751 6.158L3.25272 6.35667L3.25332 6.35734L3.47751 6.158ZM3.02269 5.18468L2.72608 5.22964L2.72608 5.22964L3.02269 5.18468ZM4.89897 3L4.89897 2.7L4.89851 2.7L4.89897 3ZM19.1035 3L19.1038 2.7H19.1035V3ZM20.1344 3.30509L20.2974 3.05324L20.2974 3.05324L20.1344 3.30509ZM20.9805 5.18545L20.684 5.14037L20.684 5.14037L20.9805 5.18545ZM20.525 6.159L20.7492 6.35834L20.7496 6.35783L20.525 6.159ZM13.2546 14.336L13.4787 14.5355L13.4788 14.5353L13.2546 14.336ZM13.0016 15L12.7016 14.9998V15H13.0016ZM14.0019 24.7C13.8503 24.7 13.7029 24.6509 13.5816 24.56L13.2217 25.04C13.4468 25.2088 13.7205 25.3 14.0019 25.3V24.7ZM14.4971 24.4949C14.3658 24.6262 14.1876 24.7 14.0019 24.7V25.3C14.3467 25.3 14.6774 25.1631 14.9213 24.9193L14.4971 24.4949ZM14.7022 24C14.7022 24.1856 14.6284 24.3637 14.4971 24.4949L14.9213 24.9193C15.1652 24.6755 15.3022 24.3448 15.3022 24H14.7022ZM14.7022 15.38V24H15.3022V15.38H14.7022ZM21.7932 7.28869L14.778 15.1807L15.2264 15.5793L22.2417 7.68731L21.7932 7.28869ZM22.6588 5.44437C22.5539 6.12971 22.2533 6.7702 21.793 7.28889L22.2418 7.68711C22.7788 7.08199 23.1295 6.33473 23.2519 5.53513L22.6588 5.44437ZM22.3843 3.4255C22.6683 4.05799 22.7636 4.75903 22.6588 5.44437L23.2519 5.53513C23.3742 4.73552 23.263 3.91761 22.9316 3.17968L22.3843 3.4255ZM21.0574 1.87889C21.6394 2.25595 22.1002 2.793 22.3843 3.4255L22.9316 3.17967C22.6002 2.44174 22.0626 1.8152 21.3836 1.37532L21.0574 1.87889ZM19.1032 1.3C19.7967 1.30081 20.4753 1.50183 21.0574 1.87889L21.3836 1.37532C20.7046 0.935446 19.913 0.700949 19.1039 0.7L19.1032 1.3ZM4.89897 1.3H19.1035V0.7H4.89897V1.3ZM2.94445 1.87793C3.52674 1.50113 4.2055 1.30044 4.89916 1.3L4.89878 0.7C4.0896 0.700511 3.29778 0.93462 2.61848 1.3742L2.94445 1.87793ZM1.61676 3.42405C1.90114 2.79162 2.36217 2.25474 2.94445 1.87793L2.61848 1.3742C1.93919 1.81378 1.40132 2.44013 1.06954 3.17798L1.61676 3.42405ZM1.34138 5.44297C1.23677 4.75753 1.33239 4.05647 1.61676 3.42405L1.06954 3.17798C0.737761 3.91583 0.626191 4.73377 0.748248 5.5335L1.34138 5.44297ZM2.2065 7.28796C1.7464 6.76908 1.44599 6.12841 1.34138 5.44297L0.748248 5.5335C0.870305 6.33322 1.22079 7.08068 1.75757 7.68604L2.2065 7.28796ZM9.22447 15.1807L2.20622 7.28766L1.75784 7.68634L8.77609 15.5793L9.22447 15.1807ZM9.30028 21V15.38H8.70028V21H9.30028ZM9.3742 21.313C9.32558 21.2158 9.30028 21.1087 9.30028 21H8.70028C8.70028 21.2018 8.74728 21.4009 8.83757 21.5814L9.3742 21.313ZM9.58037 21.56C9.49339 21.4948 9.42281 21.4102 9.3742 21.313L8.83757 21.5814C8.92786 21.7619 9.05895 21.9189 9.22044 22.04L9.58037 21.56ZM13.5816 24.56L9.58037 21.56L9.22044 22.04L13.2217 25.04L13.5816 24.56ZM10.821 20.74L12.8216 22.24L13.1815 21.76L11.1809 20.26L10.821 20.74ZM10.7009 15V20.5H11.3009V15H10.7009ZM10.5245 14.5351C10.6382 14.6633 10.701 14.8286 10.7009 14.9999L11.3009 15.0001C11.301 14.6819 11.1844 14.3748 10.9732 14.1369L10.5245 14.5351ZM3.25332 6.35734L10.5246 14.5353L10.973 14.1367L3.70171 5.95866L3.25332 6.35734ZM2.72608 5.22964C2.78952 5.64815 2.97239 6.03947 3.25272 6.35667L3.7023 5.95933C3.49842 5.72864 3.36544 5.44405 3.3193 5.13972L2.72608 5.22964ZM2.89506 3.99722C2.72131 4.38322 2.66264 4.81114 2.72608 5.22964L3.3193 5.13972C3.27317 4.83538 3.31583 4.5242 3.44219 4.24349L2.89506 3.99722ZM3.70559 3.05344C3.35023 3.28353 3.0688 3.61121 2.89506 3.99722L3.44219 4.24349C3.56854 3.96277 3.77322 3.72444 4.03169 3.55709L3.70559 3.05344ZM4.89851 2.7C4.47515 2.70064 4.06095 2.82336 3.70559 3.05344L4.03169 3.55709C4.29016 3.38973 4.59145 3.30047 4.89942 3.3L4.89851 2.7ZM19.1035 2.7H4.89897V3.3H19.1035V2.7ZM20.2974 3.05324C19.9419 2.8231 19.5274 2.70044 19.1038 2.7L19.1032 3.3C19.4113 3.30032 19.7128 3.38954 19.9714 3.55694L20.2974 3.05324ZM21.1084 3.99745C20.9346 3.61123 20.653 3.28338 20.2974 3.05324L19.9714 3.55694C20.2301 3.72434 20.4349 3.96279 20.5613 4.24366L21.1084 3.99745ZM21.2771 5.23054C21.3408 4.81184 21.2822 4.38368 21.1084 3.99745L20.5613 4.24366C20.6876 4.52453 20.7302 4.83589 20.684 5.14037L21.2771 5.23054ZM20.7496 6.35783C21.0303 6.04066 21.2135 5.64924 21.2771 5.23054L20.684 5.14037C20.6377 5.44484 20.5045 5.7295 20.3003 5.96017L20.7496 6.35783ZM13.4788 14.5353L20.7492 6.35834L20.3008 5.95966L13.0304 14.1367L13.4788 14.5353ZM13.3016 15.0002C13.3017 14.8289 13.3647 14.6635 13.4787 14.5355L13.0306 14.1365C12.8189 14.3743 12.7018 14.6814 12.7016 14.9998L13.3016 15.0002ZM13.3016 22V15H12.7016V22H13.3016Z"
                            fill="black" mask="url(#path-1-outside-1_233_13)" />
                    </svg>
                </button>

                {{-- reset --}}
                <button
                    class="flex items-center py-2 px-[10px] md:py-2 md:px-3 gap-2 rounded-md shadow-lg bg-black hover:bg-[#3b3b3b] transition ease-in-out">

                    <svg class="w-[15px] h-[15px] md:w-[18px] md:h-[18px]" viewBox="0 0 25 25" fill="none"
                        xmlns="http://www.w3.org/2000/svg">
                        <path
                            d="M3.2806 7.10146C4.55729 4.89805 6.59124 3.23371 9.00372 2.41833C11.4162 1.60295 14.0428 1.6921 16.3945 2.66919C18.7461 3.64628 20.6625 5.44471 21.7869 7.72962C22.9112 10.0145 23.1669 12.6302 22.5062 15.0895C21.8455 17.5489 20.3136 19.6844 18.1957 21.0983C16.0777 22.5122 13.5181 23.1083 10.9934 22.7754C8.46866 22.4426 6.15095 21.2036 4.47178 19.2891C2.79262 17.3746 1.86645 14.9151 1.86572 12.3685"
                            stroke="white" stroke-width="2.3" stroke-linecap="round" stroke-linejoin="round" />
                        <path d="M8.42822 7.11852L3.17822 7.11852L3.17822 1.86853" stroke="white" stroke-width="2.3"
                            stroke-linecap="round" stroke-linejoin="round" />
                    </svg>

                </button>
            </div>

        </div>

        {{-- content --}}
        <div class="flex flex-col lg:flex-row w-full lg:h-full p-2 md:p-5 gap-2 md:gap-5">

            {{-- left --}}
            <div
                class="flex flex-col w-full lg:w-[65%] h-80 md:h-96 lg:min-h-full overflow-y-auto bg-white border-[1px] border-[#DCDADA] rounded-md">
                <p class="p-4 md:p-6 2xl:p-9 text-[12px] md:text-[14px] 2xl:text-[17px]">Data Pemasukan</p>
                <div class="flex w-full border-y-[1px] border-y-[#DCDADA] bg-[#F7F7F7] text-[11px] md:text-[14px]">
                    <p class="text-center w-[20%] p-3 md:p-4 2xl:p-7 bg-[#F7F7F7]">No</p>
                    <p class="text-center w-[40%] p-3 md:p-4 2xl:p-7 bg-[#F7F7F7]">Waktu</p>
                    <p class="text-right w-[40%] py-3 md:py-4 2xl:py-7 pr-5 md:pr-7 2xl:pr-10 bg-[#F7F7F7]">Total</p>
                </div>
                <div class="w-full h-full overflow-y-auto">
                    <table class="text-[11px] md:text-[14px] w-full">
                        @for ($i = 0; $i < 30; $i++)
                            <tr class="border-b-[1px] border-b-[#DCDADA]">
                                <td class="text-center w-[20%] p-3 md:p-4 2xl:p-7 bg-white">{{ $i + 1 }}</td>
                                <td class="text-center w-[40%] p-3 md:p-4 2xl:p-7 bg-white">Jan-2023</td>
                                <td class="text-right w-[40%] py-3 md:py-4 2xl:py-7 pr-5 md:pr-7 2xl:pr-10 bg-white">Rp.
                                    320.000</td>
                            </tr>
                        @endfor
                    </table>
                </div>
            </div>

            {{-- right --}}
            <div
                class="flex flex-col w-full lg:w-[35%] lg:min-h-full lg:justify-between bg-white border-[1px] border-[#DCDADA] rounded-md">
                <p class="p-4 md:p-6 2xl:p-9 text-[12px] md:text-[15px] 2xl:text-[17px] border-b-[1px] border-b-[#DCDADA]">
                    Detail Pemasukan</p>
                <div class="flex flex-col px-4 md:px-7 2xl:px-12 h-full justify-evenly">

                    {{-- pria --}}
                    <div class="flex w-full cursor-pointer justify-between py-4 2xl:h-[30%] items-center">
                        <div class="flex gap-5">
                            <svg class="w-[51px] h-[51px] md:w-[70px] md:h-[70px] lg:w-[50px] lg:h-[50px] xl:w-[60px] xl:h-[60px] 2xl:w-[80px] 2xl:h-[80px]"
                                viewBox="0 0 105 111" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <rect width="104.765" height="110.893" rx="14" fill="#DFDFDF" />
                                <path
                                    d="M63.9998 18H40.9998C37.4998 28.5 44.4998 47 47.9998 50C51.4998 53 64.9998 41 65.9998 37C66.7998 33.8 64.9998 23 63.9998 18Z"
                                    fill="#84879C" />
                                <path
                                    d="M28.5 24.5L41 18C42.5 38 53 47.5 53.5 48C53.9 48.4 54 49.1667 54 49.5V82L44 92C43.2 92.8 42.3333 93 42 93L27.5 87C26.7 86.6 26.1667 85.5 26 85V54.5C34.5 40 29 28 28.5 26.5C28.1 25.3 28.3333 24.6667 28.5 24.5Z"
                                    fill="#B0B3C1" />
                                <rect x="31" y="72" width="14" height="3" rx="0.3"
                                    fill="#9297AB" />
                                <path
                                    d="M50 49.5C50 47.9 51.3333 46.8333 52 46.5C54 48.1 54.1667 48.8918 54 49.0876V82L52 84L50 82V49.5Z"
                                    fill="#9297AB" />
                                <path
                                    d="M76.5 24.5L64 18C62.5 38 52 47.5 51.5 48C51.1 48.4 51 49.1667 51 49.5V82L61 92C61.8 92.8 62.6667 93 63 93L77.5 87C78.3 86.6 78.8333 85.5 79 85V54.5C70.5 40 76 28 76.5 26.5C76.9 25.3 76.6667 24.6667 76.5 24.5Z"
                                    fill="#B0B3C1" />
                                <rect x="58" y="72" width="14" height="3" rx="0.3"
                                    fill="#9297AB" />
                                <path
                                    d="M63.178 48.1864C63.5757 47.6124 64.4243 47.6124 64.822 48.1864L68.1088 52.9305C68.5683 53.5937 68.0936 54.5 67.2868 54.5H60.7132C59.9064 54.5 59.4317 53.5937 59.8912 52.9305L63.178 48.1864Z"
                                    fill="#F26176" />
                                <rect x="58" y="53" width="12" height="3" rx="0.3"
                                    fill="#9297AB" />
                            </svg>

                            <div
                                class="flex flex-col h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px] text-[11px] md:text-[14px] 2xl:text-[16px] justify-center gap-2">
                                <p>Pakaian Pria</p>
                                <p class="poppins-semibold">Rp. 760.000</p>
                            </div>
                        </div>

                        <div class="flex items-center h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px]">
                            <svg class="w-[8px] h-[14px]" viewBox="0 0 16 27" fill="none"
                                xmlns="http://www.w3.org/2000/svg">
                                <path
                                    d="M15.2721 13.97C15.2721 14.2813 15.215 14.5824 15.1008 14.8734C14.9865 15.1659 14.8342 15.4094 14.6438 15.604L4.13297 26.3411C3.71406 26.769 3.1809 26.983 2.5335 26.983C1.88609 26.983 1.35294 26.769 0.934026 26.3411C0.515118 25.9132 0.305664 25.3685 0.305664 24.7072C0.305664 24.0458 0.515118 23.5012 0.934026 23.0733L9.84536 13.97L0.934026 4.86681C0.515118 4.43888 0.305664 3.89424 0.305664 3.2329C0.305664 2.57155 0.515118 2.02692 0.934026 1.59899C1.35294 1.17106 1.88609 0.957087 2.5335 0.957087C3.1809 0.957087 3.71406 1.17106 4.13297 1.59899L14.6438 12.3361C14.8723 12.5695 15.0337 12.8224 15.1282 13.0947C15.2241 13.3671 15.2721 13.6588 15.2721 13.97Z"
                                    fill="black" />
                            </svg>
                        </div>
                    </div>

                    {{-- line --}}
                    <div class="w-full h-[1px] bg-[#DCDADA]"></div>

                    {{-- Wanita --}}
                    <div class="flex w-full cursor-pointer justify-between py-4 2xl:h-[30%] items-center">
                        <div class="flex gap-5">
                            <svg class="w-[51px] h-[51px] md:w-[70px] md:h-[70px] lg:w-[50px] lg:h-[50px] xl:w-[60px] xl:h-[60px] 2xl:w-[80px] 2xl:h-[80px]"
                                viewBox="0 0 105 111" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <rect width="104.765" height="110.893" rx="14" fill="#EDD9ED" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M44.0137 15.5H36.5017C34.2284 16.4741 29.551 20.0104 28.5709 26.4785L26.4571 28.875C26.2744 29.0821 26.2942 29.398 26.5013 29.5807L35.1716 37.2265C35.3787 37.4091 35.6947 37.3893 35.8774 37.1822L39.0513 33.5838C40.5194 36.0888 41.2933 40.0444 40.5021 44L22 84.5C22.5001 86.3333 25.3004 89.8 32.5012 89C33.0013 90.6667 35.7016 93.8 42.5023 93C43.7754 94.1138 47.5399 96.0175 52.7517 95.1436C57.9628 96.0175 61.7269 94.1138 62.9998 93C69.7998 93.8 72.4998 90.6667 72.9998 89C80.1998 89.8 82.9998 86.3333 83.4998 84.5L64.9998 44C64.2086 40.0443 64.9825 36.0887 66.4505 33.5837L69.6241 37.1822C69.8068 37.3893 70.1227 37.4091 70.3298 37.2265L78.9991 29.5807C79.2062 29.398 79.226 29.0821 79.0434 28.875L76.9296 26.4783C75.9496 20.0103 71.2727 16.4741 68.9998 15.5H61.9863C61.7269 20.238 57.8028 24 53 24C48.1972 24 44.2731 20.238 44.0137 15.5Z"
                                    fill="#B88CB8" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M75.5551 89.1098L75.5002 89L61.5002 56L72.5002 88.5L72.9824 89.0564C72.9885 89.0374 72.9944 89.0186 73 89C73.9224 89.1025 74.7726 89.135 75.5551 89.1098ZM65.0216 93.1282L65.0002 93L58.5002 59L63.0002 92.5L63.2435 93.0272C63.8715 93.0933 64.4636 93.1255 65.0216 93.1282ZM53.3454 95.2322L53.5002 95L52.0002 59L51.5348 95.3013C51.9309 95.2652 52.3368 95.2132 52.7518 95.1436C52.9518 95.1772 53.1497 95.2066 53.3454 95.2322ZM42.5001 93.0003L42.5002 93L47.0002 59L40.8334 93.1227C41.3594 93.1087 41.9145 93.0691 42.5001 93.0003ZM32.5001 89.0001L32.5002 89L44.0002 56L30.1382 89.1148C30.8669 89.1292 31.653 89.0942 32.5001 89.0001Z"
                                    fill="#AD74AE" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M76.9062 26.3289L76.5 26.5L67.5 34.5L67.5442 34.8238L69.6241 37.1822C69.8068 37.3893 70.1227 37.4091 70.3298 37.2264L78.9991 29.5807C79.2062 29.398 79.226 29.082 79.0434 28.8749L76.9296 26.4782C76.922 26.4283 76.9142 26.3785 76.9062 26.3289ZM37.9464 34.8365L38.0002 34.5L28.5299 26.5249L26.4571 28.875C26.2744 29.0821 26.2942 29.398 26.5013 29.5806L35.1716 37.2264C35.3787 37.4091 35.6947 37.3893 35.8774 37.1822L37.9464 34.8365Z"
                                    fill="#AD74AE" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M64.7022 40H40.7994C40.8601 41.2947 40.7725 42.6473 40.502 44H64.9996C64.7291 42.6473 64.6415 41.2947 64.7022 40Z"
                                    fill="#AD74AE" />
                            </svg>

                            <div
                                class="flex flex-col h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px] text-[11px] md:text-[14px] 2xl:text-[16px] justify-center gap-2">
                                <p>Pakaian Wanita</p>
                                <p class="poppins-semibold">Rp. 760.000</p>
                            </div>
                        </div>

                        <div class="flex items-center h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px]">
                            <svg class="w-[8px] h-[14px]" viewBox="0 0 16 27" fill="none"
                                xmlns="http://www.w3.org/2000/svg">
                                <path
                                    d="M15.2721 13.97C15.2721 14.2813 15.215 14.5824 15.1008 14.8734C14.9865 15.1659 14.8342 15.4094 14.6438 15.604L4.13297 26.3411C3.71406 26.769 3.1809 26.983 2.5335 26.983C1.88609 26.983 1.35294 26.769 0.934026 26.3411C0.515118 25.9132 0.305664 25.3685 0.305664 24.7072C0.305664 24.0458 0.515118 23.5012 0.934026 23.0733L9.84536 13.97L0.934026 4.86681C0.515118 4.43888 0.305664 3.89424 0.305664 3.2329C0.305664 2.57155 0.515118 2.02692 0.934026 1.59899C1.35294 1.17106 1.88609 0.957087 2.5335 0.957087C3.1809 0.957087 3.71406 1.17106 4.13297 1.59899L14.6438 12.3361C14.8723 12.5695 15.0337 12.8224 15.1282 13.0947C15.2241 13.3671 15.2721 13.6588 15.2721 13.97Z"
                                    fill="black" />
                            </svg>
                        </div>
                    </div>

                    {{-- line --}}
                    <div class="w-full h-[1px] bg-[#DCDADA]"></div>

                    {{-- Anak --}}
                    <div class="flex w-full cursor-pointer justify-between py-4 2xl:h-[30%] items-center">
                        <div class="flex gap-5">
                            <svg class="w-[51px] h-[51px] md:w-[70px] md:h-[70px] lg:w-[50px] lg:h-[50px] xl:w-[60px] xl:h-[60px] 2xl:w-[80px] 2xl:h-[80px]"
                                viewBox="0 0 105 111" fill="none" xmlns="http://www.w3.org/2000/svg">
                                <rect width="104.765" height="110.893" rx="14" fill="#D5ECFE" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M52 27C54 26.8333 58.7 25.4 61.5 21C61.6667 20.6667 62.4 20.2 64 21C64.4579 21.2289 65.3088 21.5103 66.3908 21.868C70.0353 23.073 76.3013 25.1447 79 29L84.5 37.5V42.5L80 47C79.3333 47.5 77.6 48.3 76 47.5C74.4 46.7 72.3333 45.5 71.5 45C73.3333 52 76.2 69.7 73 84.5C72.6667 86.1667 71.4 89.5 69 89.5H61.5C61 89.1667 59.7 87.7 58.5 84.5L56 77.5C56 77 55.6 76 54.0001 76L54 76.0004H49.5C47.9 76.0004 47.5 77.0003 47.5 77.5003L45 84.5001C43.8 87.7001 42.5 89.1667 42 89.5H34.5C32.1 89.5 30.8333 86.1668 30.5 84.5001C27.3 69.7005 30.1667 52.001 32 45.0011C31.1667 45.5011 29.1 46.7011 27.5 47.5011C25.9 48.301 24.1667 47.5011 23.5 47.0011L19 42.5012V37.5013L24.5 29.0015C27.1987 25.1463 33.4648 23.0746 37.1092 21.8697C38.1912 21.512 39.0421 21.2306 39.5 21.0017C41.1 20.2017 41.8333 20.6684 42 21.0017C44.8 25.4016 49.5 26.8349 51.5 27.0016L51.7406 27.0216L52 27Z"
                                    fill="#80C9FF" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M66.7201 21.977C64.2787 27.8701 58.6069 32 51.9999 32C45.339 32 39.6288 27.8026 37.2207 21.8328C38.2496 21.4925 39.0579 21.2227 39.4999 21.0017C41.0999 20.2017 41.8332 20.6684 41.9999 21.0017C44.7999 25.4016 49.4999 26.8349 51.4999 27.0016L51.7405 27.0216L51.9999 27C53.9999 26.8333 58.6999 25.4 61.4999 21C61.6665 20.6667 62.3999 20.2 63.9999 21C64.4577 21.2289 65.3087 21.5103 66.3907 21.868C66.4982 21.9036 66.6081 21.9399 66.7201 21.977Z"
                                    fill="#6DAAD9" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M29.7887 46.2782C29.0346 46.7 28.22 47.141 27.5 47.501C25.9 48.301 24.1667 47.501 23.5 47.0011L19 42.5012V37.5013L19.9806 35.9859C19.987 35.9906 19.9935 35.9953 19.9999 36L29.7887 46.2782ZM83.5201 35.9856L84.5 37.5V42.5L80 47C79.3333 47.5 77.6 48.3 76 47.5C75.3827 47.1914 74.696 46.8232 74.0374 46.4586L83.5 36L83.5201 35.9856Z"
                                    fill="#6DAAD9" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M73.1057 84L58.3216 84L58.5001 84.5C59.7001 87.7 61.0001 89.1667 61.5001 89.5H69.0001C71.4001 89.5 72.6668 86.1667 73.0001 84.5C73.0361 84.3337 73.0713 84.167 73.1057 84ZM45.1788 84L45.0001 84.5001C43.8001 87.7 42.5001 89.1667 42.0001 89.5H34.5001C32.1001 89.5 30.8335 86.1667 30.5001 84.5001C30.4642 84.3338 30.429 84.1671 30.3945 84L45.1788 84Z"
                                    fill="#6DAAD9" />
                                <circle cx="60.5" cy="44.5" r="4.5" fill="#D98F2D" />
                                <circle cx="43.5" cy="44.5" r="4.5" fill="#D98F2D" />
                                <ellipse cx="52" cy="51" rx="11" ry="10" fill="#FFB641" />
                                <path fill-rule="evenodd" clip-rule="evenodd"
                                    d="M50.5 50C50.5 49.6667 50.6 49 51 49H53C53.4 49 53.5 49.6667 53.5 50C53.5 50.8 52.5 51 52 51C51.5 51 50.5 50.8 50.5 50Z"
                                    fill="#38484A" />
                                <rect x="57" y="48" width="2" height="3" rx="1"
                                    fill="#38484A" />
                                <rect x="45" y="48" width="2" height="3" rx="1"
                                    fill="#38484A" />
                                <path
                                    d="M50 52C50.8 52.8 51.6667 53 52 53C52.5 53 53 52.5 54 52C55 51.5 55.5 52 55.5 53C55.5 54 53 55 52 55C51 55 49 54.5 48.5 53C48.1 51.8 49.3333 51.8333 50 52Z"
                                    fill="#38484A" />
                            </svg>

                            <div
                                class="flex flex-col h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px] text-[11px] md:text-[14px] 2xl:text-[16px] justify-center gap-2">
                                <p>Pakaian Anak</p>
                                <p class="poppins-semibold">Rp. 760.000</p>
                            </div>
                        </div>

                        <div class="flex items-center h-[51px] md:h-[70px] lg:h-[50px] xl:h-[60px] 2xl:h-[80px]">
                            <svg class="w-[8px] h-[14px]" viewBox="0 0 16 27" fill="none"
                                xmlns="http://www.w3.org/2000/svg">
                                <path
                                    d="M15.2721 13.97C15.2721 14.2813 15.215 14.5824 15.1008 14.8734C14.9865 15.1659 14.8342 15.4094 14.6438 15.604L4.13297 26.3411C3.71406 26.769 3.1809 26.983 2.5335 26.983C1.88609 26.983 1.35294 26.769 0.934026 26.3411C0.515118 25.9132 0.305664 25.3685 0.305664 24.7072C0.305664 24.0458 0.515118 23.5012 0.934026 23.0733L9.84536 13.97L0.934026 4.86681C0.515118 4.43888 0.305664 3.89424 0.305664 3.2329C0.305664 2.57155 0.515118 2.02692 0.934026 1.59899C1.35294 1.17106 1.88609 0.957087 2.5335 0.957087C3.1809 0.957087 3.71406 1.17106 4.13297 1.59899L14.6438 12.3361C14.8723 12.5695 15.0337 12.8224 15.1282 13.0947C15.2241 13.3671 15.2721 13.6588 15.2721 13.97Z"
                                    fill="black" />
                            </svg>
                        </div>
                    </div>
                </div>
                <p
                    class="flex justify-center p-4 md:p-6 2xl:p-9 lg:p-5 text-[12px] md:text-[15px] 2xl:text-[17px] border-t-[1px] border-t-[#DCDADA] poppins-semibold">
                    Rp. 2.280.000</p>
            </div>

        </div>

    </div>
@endsection

@section('otherjs')
    <script src="{{ asset('js/controllers/laporan_pemasukan.js') }}"></script>
@endsection
