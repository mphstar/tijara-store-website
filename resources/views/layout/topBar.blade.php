<div
    class="flex flex-row justify-between items-center max-lg:w-full  lg:h-[100px] h-[60px] bg-white border-b-[1px] border-b-[#DCDADA]">

    {{-- title --}}
    <div class="flex flex-row max-lg:items-center lg:flex-col lg:py-[29px] px-[20px] lg:px-[50px]">
        {{-- <h4 class="poppins-medium text-black text-[23px]">@yield("title_menu")</h4>
        <p class="poppins-medium text-[18px] text-[#989696] ml-2">@yield("detail_title_menu")</p> --}}
        <div id="burger" class="lg:hidden">
            <svg xmlns="http://www.w3.org/2000/svg" xmlns:xlink="http://www.w3.org/1999/xlink" version="1.1" id="Capa_1"
                x="0px" y="0px" viewBox="0 0 512 512" style="enable-background:new 0 0 512 512;"
                xml:space="preserve" class="w-[18px] h-[18px] mr-5">
                <g>
                    <path
                        d="M480,224H32c-17.673,0-32,14.327-32,32s14.327,32,32,32h448c17.673,0,32-14.327,32-32S497.673,224,480,224z" />
                    <path
                        d="M32,138.667h448c17.673,0,32-14.327,32-32s-14.327-32-32-32H32c-17.673,0-32,14.327-32,32S14.327,138.667,32,138.667z" />
                    <path
                        d="M480,373.333H32c-17.673,0-32,14.327-32,32s14.327,32,32,32h448c17.673,0,32-14.327,32-32S497.673,373.333,480,373.333z" />
                </g>
            </svg>
        </div>
        <div class="flex flex-row">
            <p class="poppins-medium text-black lg:text-[21px] text-[12px]">@yield("title")</p>
            <p class="poppins-medium text-black lg:text-[21px] text-[12px] ml-2">@yield("sub_title")</p>
        </div>
    </div>

    {{-- setting --}}
    <div class="flex h-full lg:w-[100px] w-[60px] border-l-[1px] bg-white border-l-[#DCDADA] justify-center items-center">

        <svg class="cursor-pointer lg:w-[34px] lg:h-[34px] w-[20px] h-[20px] fill-[#696969] transition ease-in-out" viewBox="0 0 31 34"
            xmlns="http://www.w3.org/2000/svg">
            <path fill-rule="evenodd" clip-rule="evenodd"
                d="M27.762 19.329L28.3894 19.6917L28.3908 19.6903C29.3652 20.2538 30.0764 21.1824 30.3679 22.2717C30.6594 23.3609 30.5074 24.5217 29.9452 25.4986C29.3831 26.4755 28.4569 27.1884 27.3703 27.4807C26.2838 27.7729 25.126 27.6205 24.1516 27.0569L23.52 26.6914C22.3332 27.7106 20.9689 28.5011 19.4956 29.0232V29.75C19.4956 30.8772 19.049 31.9582 18.254 32.7552C17.459 33.5522 16.3807 34 15.2564 34C14.1321 34 13.0538 33.5522 12.2588 32.7552C11.4638 31.9582 11.0172 30.8772 11.0172 29.75V29.0232C9.54334 28.5031 8.17801 27.7145 6.98996 26.6971L6.36114 27.0612C5.38675 27.6248 4.22894 27.7772 3.14244 27.4849C2.05593 27.1927 1.12973 26.4797 0.567574 25.5028C0.00542137 24.526 -0.146629 23.3652 0.144872 22.2759C0.436374 21.1867 1.14755 20.2581 2.12195 19.6945L2.74935 19.3318C2.46689 17.7911 2.46689 16.2117 2.74935 14.671L2.12195 14.3083C1.14755 13.7447 0.436374 12.8162 0.144872 11.7269C-0.146629 10.6376 0.00542137 9.47688 0.567574 8.5C1.12973 7.52312 2.05593 6.81013 3.14244 6.51789C4.22894 6.22564 5.38675 6.37808 6.36114 6.94167L6.99278 7.30858C8.17954 6.28943 9.54392 5.49889 11.0172 4.97675V4.25C11.0172 3.12283 11.4638 2.04183 12.2588 1.2448C13.0538 0.447767 14.1321 0 15.2564 0C16.3807 0 17.459 0.447767 18.254 1.2448C19.049 2.04183 19.4956 3.12283 19.4956 4.25V4.97675C20.9689 5.49702 22.3338 6.28563 23.5214 7.30292L24.1502 6.93883C24.6327 6.65977 25.1653 6.47872 25.7175 6.40601C26.2698 6.3333 26.831 6.37035 27.3689 6.51505C27.9069 6.65976 28.4112 6.90928 28.853 7.24937C29.2948 7.58946 29.6655 8.01346 29.9438 8.49717C30.2222 8.98087 30.4027 9.5148 30.4753 10.0685C30.5478 10.6221 30.5108 11.1847 30.3665 11.7241C30.2222 12.2634 29.9733 12.769 29.6341 13.2119C29.2948 13.6548 28.8719 14.0264 28.3894 14.3055L27.762 14.6682C28.0445 16.2089 28.0445 17.7883 27.762 19.329ZM24.7889 19.6548C25.2675 17.9165 25.2675 16.0807 24.7889 14.3423V14.3438C24.7066 14.0421 24.7262 13.7217 24.8445 13.4324C24.9629 13.1431 25.1734 12.9012 25.4432 12.7443L26.9749 11.8575C27.1369 11.7652 27.2791 11.6416 27.3933 11.4939C27.5075 11.3463 27.5914 11.1775 27.6402 10.9971C27.6891 10.8168 27.7018 10.6286 27.6778 10.4434C27.6538 10.2581 27.5935 10.0794 27.5003 9.91762C27.4071 9.75582 27.2829 9.6141 27.1349 9.50061C26.9868 9.38712 26.8179 9.30411 26.6377 9.25636C26.4576 9.20861 26.2697 9.19705 26.0851 9.22236C25.9005 9.24767 25.7226 9.30935 25.5619 9.40383L24.0301 10.2921C23.7587 10.4497 23.4426 10.5123 23.1318 10.47C22.8209 10.4276 22.5329 10.2828 22.3132 10.0583C21.0562 8.769 19.4716 7.84855 17.7307 7.39642C17.4269 7.31812 17.1578 7.14073 16.9656 6.8922C16.7735 6.64366 16.6693 6.33811 16.6695 6.02367V4.25C16.6695 3.87428 16.5206 3.51394 16.2556 3.24827C15.9906 2.98259 15.6312 2.83333 15.2564 2.83333C14.8816 2.83333 14.5222 2.98259 14.2572 3.24827C13.9922 3.51394 13.8433 3.87428 13.8433 4.25V6.02367C13.8447 6.33908 13.7411 6.64594 13.5489 6.89563C13.3567 7.14532 13.0868 7.32355 12.7821 7.40208C11.0418 7.85261 9.45729 8.77107 8.19954 10.0583C7.97926 10.2816 7.69123 10.4251 7.38071 10.4664C7.07019 10.5077 6.75479 10.4444 6.48408 10.2864L4.94949 9.39675C4.62475 9.20889 4.23888 9.15805 3.87676 9.25542C3.51463 9.35279 3.20592 9.59039 3.01854 9.91596C2.83115 10.2415 2.78044 10.6284 2.87757 10.9914C2.97469 11.3545 3.21169 11.664 3.53643 11.8518L5.06819 12.7387C5.33853 12.8951 5.54961 13.1368 5.66848 13.4262C5.78735 13.7155 5.80732 14.0362 5.72526 14.3381C5.24674 16.0764 5.24674 17.9122 5.72526 19.6506C5.80882 19.9531 5.78976 20.275 5.67109 20.5655C5.55241 20.856 5.34084 21.0988 5.0696 21.2557L3.53784 22.1425C3.37584 22.2348 3.23365 22.3584 3.11948 22.5061C3.0053 22.6537 2.92138 22.8225 2.87255 23.0029C2.82373 23.1832 2.81096 23.3714 2.83498 23.5566C2.859 23.7419 2.91933 23.9206 3.01251 24.0824C3.10569 24.2442 3.22987 24.3859 3.37791 24.4994C3.52594 24.6129 3.69491 24.6959 3.87507 24.7436C4.05524 24.7914 4.24304 24.8029 4.42768 24.7776C4.61232 24.7523 4.79014 24.6907 4.9509 24.5962L6.48267 23.7079C6.75413 23.5503 7.07018 23.4877 7.38103 23.53C7.69188 23.5724 7.97985 23.7172 8.19954 23.9417C9.45622 25.2308 11.0403 26.1512 12.7807 26.6036C13.0845 26.6819 13.3536 26.8593 13.5457 27.1078C13.7379 27.3563 13.8421 27.6619 13.8419 27.9763V29.75C13.8419 30.1257 13.9908 30.4861 14.2558 30.7517C14.5208 31.0174 14.8802 31.1667 15.255 31.1667C15.6297 31.1667 15.9892 31.0174 16.2542 30.7517C16.5192 30.4861 16.668 30.1257 16.668 29.75V27.9749C16.6679 27.6605 16.7721 27.3549 16.9642 27.1064C17.1563 26.8578 17.4255 26.6805 17.7293 26.6022C19.4696 26.1516 21.0541 25.2332 22.3118 23.9459C22.5315 23.7214 22.8195 23.5766 23.1303 23.5343C23.4412 23.492 23.7572 23.5545 24.0287 23.7122L25.5633 24.6018C25.888 24.7897 26.2739 24.8405 26.636 24.7432C26.9982 24.6458 27.3069 24.4082 27.4942 24.0826C27.6816 23.7571 27.7323 23.3702 27.6352 23.0072C27.5381 22.6441 27.3011 22.3346 26.9764 22.1467L25.4446 21.2599C25.1734 21.103 24.9618 20.8603 24.8431 20.5697C24.7244 20.2792 24.7054 19.9574 24.7889 19.6548ZM12.1081 12.2883C13.04 11.6657 14.1356 11.3333 15.2564 11.3333C16.7593 11.3333 18.2006 11.9304 19.2633 12.9931C20.326 14.0558 20.923 15.4971 20.923 17C20.923 18.1208 20.5907 19.2164 19.968 20.1482C19.3454 21.0801 18.4604 21.8064 17.4249 22.2353C16.3895 22.6642 15.2501 22.7764 14.1509 22.5578C13.0516 22.3391 12.0419 21.7994 11.2494 21.0069C10.4569 20.2144 9.91724 19.2047 9.69859 18.1055C9.47994 17.0063 9.59216 15.8669 10.0211 14.8315C10.45 13.796 11.1763 12.911 12.1081 12.2883ZM13.6823 19.3558C14.1482 19.6672 14.696 19.8333 15.2564 19.8333C16.0078 19.8333 16.7285 19.5348 17.2598 19.0035C17.7912 18.4721 18.0897 17.7515 18.0897 17C18.0897 16.4396 17.9235 15.8918 17.6122 15.4259C17.3009 14.96 16.8584 14.5968 16.3406 14.3823C15.8229 14.1679 15.2532 14.1118 14.7036 14.2211C14.154 14.3304 13.6492 14.6003 13.2529 14.9965C12.8567 15.3928 12.5868 15.8976 12.4775 16.4473C12.3682 16.9969 12.4243 17.5666 12.6387 18.0843C12.8532 18.602 13.2163 19.0445 13.6823 19.3558Z" />
        </svg>

    </div>
</div>