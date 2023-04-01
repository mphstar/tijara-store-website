
<div class="w-screen h-screen bg-black fixed z-[98] opacity-50 hidden transition ease-in delay-300" id="bg-sidebar"></div>


<div class="main-sidebar flex flex-col lg:w-[25%] xl:w-[20%] w-[60%] h-screen bg-white border-r-[1px] border-r-[#DCDADA] box-border fixed z-[99]"
    id="sidebar">

    
    <div class="flex flex-col w-full p-8">

        
        <img src="<?php echo e(asset('assets/images/logo.svg')); ?>" alt="logo tijara" class="md:w-[206px] w-[120px]">

        
        <div class="w-[70px] h-[70px] md:w-[100px] md:h-[100px] rounded-full overflow-hidden mt-8 md:mt-[45px]">
            <img src="<?php echo e(asset('assets/images/avatar.png')); ?>" alt="avatar" class="w-[100px] h-[100px] object-cover">
        </div>

        
        <h3 class="poppins-medium text-[15px] md:text-[18px] mt-[13px]">Bintang Kabel Prekes</h3>

        
        <p class="poppins-medium text-[12px] md:text-[14px] mt-[4px] text-[#535353]">mphstar</p>

        
        <div class="w-full h-[1px] bg-[#CACACA] mt-[30px]"></div>

    </div>
    

    
    <div class="flex flex-col pl-8 mt-2 md:mt-[49px] overflow-y-auto md:scrollbar-hide">

        
        <div class="flex flex-row justify-between h-9 md:h-[48px] cursor-pointer menu">

            
            <div class="flex flex-row menu-hover1 items-center w-full">
                <svg class="w-6 h-6 md:w-[30px] md:h-[30px] fill-black transition ease-in-out" viewBox="0 0 32 30"
                    xmlns="http://www.w3.org/2000/svg">
                    <path fill-rule="evenodd" clip-rule="evenodd"
                        d="M16.0333 2.59091C16.2193 2.68203 16.4231 2.72866 16.6293 2.72727H25.3333C27.1008 2.72944 28.7953 3.44848 30.045 4.72666C31.2948 6.00485 31.9979 7.73783 32 9.54545V23.1818C31.9979 24.9894 31.2948 26.7224 30.045 28.0006C28.7953 29.2788 27.1008 29.9978 25.3333 30H6.66667C4.89921 29.9978 3.20474 29.2788 1.95496 28.0006C0.705176 26.7224 0.00211714 24.9894 0 23.1818V6.81818C0.00211714 5.01055 0.705176 3.27758 1.95496 1.99939C3.20474 0.721203 4.89921 0.00216526 6.66667 0H10.0373C10.6579 0.000526829 11.2699 0.148016 11.8253 0.430909L16.0333 2.59091ZM10.6333 2.86364C10.4474 2.77251 10.2435 2.72588 10.0373 2.72727H6.66667C5.6058 2.72727 4.58839 3.15828 3.83824 3.92547C3.08809 4.69267 2.66667 5.73321 2.66667 6.81818V8.17364L29.0387 8.02091C28.7415 7.26415 28.23 6.61548 27.5697 6.1582C26.9095 5.70091 26.1307 5.45588 25.3333 5.45455H16.6293C16.0083 5.4519 15.3963 5.30207 14.8413 5.01682L10.6333 2.86364ZM3.83824 26.0745C4.58839 26.8417 5.6058 27.2727 6.66667 27.2727H25.3333C26.3942 27.2727 27.4116 26.8417 28.1618 26.0745C28.9119 25.3073 29.3333 24.2668 29.3333 23.1818V10.7468L2.66667 10.9009V23.1818C2.66667 24.2668 3.08809 25.3073 3.83824 26.0745Z" />
                </svg>
                <p class="ml-5 poppins-medium text-[15px] md:text-[16px] transition ease-in-out">Master Data</p>
            </div>

            
            <div class="w-2 h-full menu-hover2 transition ease-in-out"></div>
        </div>
        

        
        <?php for($i = 0; $i < 3; $i++): ?>
            <div class="flex flex-row justify-between h-9 md:h-[48px] cursor-pointer menu mt-[28px]">

                
                <div class="flex flex-row menu-hover1 items-center w-full">

                    <svg class="w-6 h-[29px] md:w-[30px] md:h-[35px] fill-black transition ease-in-out"
                        viewBox="0 0 30 40" xmlns="http://www.w3.org/2000/svg">
                        <path fill-rule="evenodd" clip-rule="evenodd"
                            d="M21.45 0H21.6667C23.876 0.00264643 25.9941 0.88147 27.5563 2.4437C29.1185 4.00593 29.9974 6.12401 30 8.33333V35C30 36.3261 29.4732 37.5979 28.5355 38.5355C27.5979 39.4732 26.3261 40 25 40H21.45C20.7041 39.9929 19.9817 39.7383 19.3962 39.2762C18.8106 38.814 18.3952 38.1705 18.215 37.4467C18.022 36.7419 17.6029 36.1201 17.022 35.6769C16.4411 35.2337 15.7307 34.9936 15 34.9936C14.2693 34.9936 13.5589 35.2337 12.978 35.6769C12.3971 36.1201 11.978 36.7419 11.785 37.4467C11.6048 38.1705 11.1894 38.814 10.6038 39.2762C10.0183 39.7383 9.2959 39.9929 8.55 40H5C3.67392 40 2.40215 39.4732 1.46447 38.5355C0.526784 37.5979 0 36.3261 0 35V8.33333C0.00264643 6.12401 0.88147 4.00593 2.4437 2.4437C4.00593 0.88147 6.12401 0.00264643 8.33333 0H8.55C9.2959 0.00708636 10.0183 0.261689 10.6038 0.723832C11.1894 1.18598 11.6048 1.82949 11.785 2.55333C11.978 3.25806 12.3971 3.87987 12.978 4.32309C13.5589 4.76631 14.2693 5.00639 15 5.00639C15.7307 5.00639 16.4411 4.76631 17.022 4.32309C17.6029 3.87987 18.022 3.25806 18.215 2.55333C18.3952 1.82949 18.8106 1.18598 19.3962 0.723832C19.9817 0.261689 20.7041 0.00708636 21.45 0ZM21.4283 36.5617L25 36.6667C25.442 36.6667 25.866 36.4911 26.1785 36.1785C26.4911 35.866 26.6667 35.442 26.6667 35V28.3333H23.3333C22.8913 28.3333 22.4674 28.1577 22.1548 27.8452C21.8423 27.5326 21.6667 27.1087 21.6667 26.6667C21.6667 26.2246 21.8423 25.8007 22.1548 25.4882C22.4674 25.1756 22.8913 25 23.3333 25H26.6667V8.33333C26.6667 7.00725 26.1399 5.73548 25.2022 4.7978C24.2645 3.86012 22.9927 3.33333 21.6667 3.33333H21.4883C21.0994 4.75991 20.2551 6.02037 19.0838 6.92294C17.9126 7.8255 16.4786 8.32075 15 8.33333C13.5411 8.33087 12.1231 7.8511 10.9624 6.96725C9.80166 6.08341 8.96204 4.84404 8.57167 3.43833L8.33333 3.33333C7.00725 3.33333 5.73548 3.86012 4.7978 4.7978C3.86012 5.73548 3.33333 7.00725 3.33333 8.33333V25H6.66667C7.10869 25 7.53262 25.1756 7.84518 25.4882C8.15774 25.8007 8.33333 26.2246 8.33333 26.6667C8.33333 27.1087 8.15774 27.5326 7.84518 27.8452C7.53262 28.1577 7.10869 28.3333 6.66667 28.3333H3.33333V35C3.33333 35.442 3.50893 35.866 3.82149 36.1785C4.13405 36.4911 4.55797 36.6667 5 36.6667H8.55C8.91835 35.2462 9.74509 33.9869 10.902 33.0841C12.059 32.1814 13.4815 31.6856 14.9489 31.6736C16.4163 31.6616 17.8467 32.1342 19.0182 33.018C20.1897 33.9017 21.0369 35.1474 21.4283 36.5617ZM13.3333 25H16.6666C17.1087 25 17.5326 25.1756 17.8451 25.4882C18.1577 25.8007 18.3333 26.2246 18.3333 26.6667C18.3333 27.1087 18.1577 27.5326 17.8451 27.8452C17.5326 28.1577 17.1087 28.3333 16.6666 28.3333H13.3333C12.8913 28.3333 12.4673 28.1577 12.1548 27.8452C11.8422 27.5326 11.6666 27.1087 11.6666 26.6667C11.6666 26.2246 11.8422 25.8007 12.1548 25.4882C12.4673 25.1756 12.8913 25 13.3333 25Z" />
                    </svg>

                    <p class="ml-5 poppins-medium text-[15px] md:text-[16px] transition ease-in-out">Voucher & Diskon
                    </p>
                </div>

                
                <div class="w-2 h-full menu-hover2 transition ease-in-out"></div>
            </div>
        <?php endfor; ?>
        

    </div>
    
</div>
<?php /**PATH D:\Development\Web\Tijara\src\resources\views/layout/sidebar.blade.php ENDPATH**/ ?>