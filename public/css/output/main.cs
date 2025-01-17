/* ============================ Coppy script dibawah kalo mau buat file input baru ============================ */

/* ! tailwindcss v3.2.7 | MIT License | https://tailwindcss.com */

/*
1. Prevent padding and border from affecting element width. (https://github.com/mozdevs/cssremedy/issues/4)
2. Allow adding a border to an element by just adding a border-width. (https://github.com/tailwindcss/tailwindcss/pull/116)
*/

*,
::before,
::after {
  box-sizing: border-box;
  /* 1 */
  border-width: 0;
  /* 2 */
  border-style: solid;
  /* 2 */
  border-color: #e5e7eb;
  /* 2 */
}

::before,
::after {
  --tw-content: '';
}

/*
1. Use a consistent sensible line-height in all browsers.
2. Prevent adjustments of font size after orientation changes in iOS.
3. Use a more readable tab size.
4. Use the user's configured `sans` font-family by default.
5. Use the user's configured `sans` font-feature-settings by default.
*/

html {
  line-height: 1.5;
  /* 1 */
  -webkit-text-size-adjust: 100%;
  /* 2 */
  -moz-tab-size: 4;
  /* 3 */
  -o-tab-size: 4;
     tab-size: 4;
  /* 3 */
  font-family: ui-sans-serif, system-ui, -apple-system, BlinkMacSystemFont, "Segoe UI", Roboto, "Helvetica Neue", Arial, "Noto Sans", sans-serif, "Apple Color Emoji", "Segoe UI Emoji", "Segoe UI Symbol", "Noto Color Emoji";
  /* 4 */
  font-feature-settings: normal;
  /* 5 */
}

/*
1. Remove the margin in all browsers.
2. Inherit line-height from `html` so users can set them as a class directly on the `html` element.
*/

body {
  margin: 0;
  /* 1 */
  line-height: inherit;
  /* 2 */
}

/*
1. Add the correct height in Firefox.
2. Correct the inheritance of border color in Firefox. (https://bugzilla.mozilla.org/show_bug.cgi?id=190655)
3. Ensure horizontal rules are visible by default.
*/

hr {
  height: 0;
  /* 1 */
  color: inherit;
  /* 2 */
  border-top-width: 1px;
  /* 3 */
}

/*
Add the correct text decoration in Chrome, Edge, and Safari.
*/

abbr:where([title]) {
  -webkit-text-decoration: underline dotted;
          text-decoration: underline dotted;
}

/*
Remove the default font size and weight for headings.
*/

h1,
h2,
h3,
h4,
h5,
h6 {
  font-size: inherit;
  font-weight: inherit;
}

/*
Reset links to optimize for opt-in styling instead of opt-out.
*/

a {
  color: inherit;
  text-decoration: inherit;
}

/*
Add the correct font weight in Edge and Safari.
*/

b,
strong {
  font-weight: bolder;
}

/*
1. Use the user's configured `mono` font family by default.
2. Correct the odd `em` font sizing in all browsers.
*/

code,
kbd,
samp,
pre {
  font-family: ui-monospace, SFMono-Regular, Menlo, Monaco, Consolas, "Liberation Mono", "Courier New", monospace;
  /* 1 */
  font-size: 1em;
  /* 2 */
}

/*
Add the correct font size in all browsers.
*/

small {
  font-size: 80%;
}

/*
Prevent `sub` and `sup` elements from affecting the line height in all browsers.
*/

sub,
sup {
  font-size: 75%;
  line-height: 0;
  position: relative;
  vertical-align: baseline;
}

sub {
  bottom: -0.25em;
}

sup {
  top: -0.5em;
}

/*
1. Remove text indentation from table contents in Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=999088, https://bugs.webkit.org/show_bug.cgi?id=201297)
2. Correct table border color inheritance in all Chrome and Safari. (https://bugs.chromium.org/p/chromium/issues/detail?id=935729, https://bugs.webkit.org/show_bug.cgi?id=195016)
3. Remove gaps between table borders by default.
*/

table {
  text-indent: 0;
  /* 1 */
  border-color: inherit;
  /* 2 */
  border-collapse: collapse;
  /* 3 */
}

/*
1. Change the font styles in all browsers.
2. Remove the margin in Firefox and Safari.
3. Remove default padding in all browsers.
*/

button,
input,
optgroup,
select,
textarea {
  font-family: inherit;
  /* 1 */
  font-size: 100%;
  /* 1 */
  font-weight: inherit;
  /* 1 */
  line-height: inherit;
  /* 1 */
  color: inherit;
  /* 1 */
  margin: 0;
  /* 2 */
  padding: 0;
  /* 3 */
}

/*
Remove the inheritance of text transform in Edge and Firefox.
*/

button,
select {
  text-transform: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Remove default button styles.
*/

button,
[type='button'],
[type='reset'],
[type='submit'] {
  -webkit-appearance: button;
  /* 1 */
  background-color: transparent;
  /* 2 */
  background-image: none;
  /* 2 */
}

/*
Use the modern Firefox focus style for all focusable elements.
*/

:-moz-focusring {
  outline: auto;
}

/*
Remove the additional `:invalid` styles in Firefox. (https://github.com/mozilla/gecko-dev/blob/2f9eacd9d3d995c937b4251a5557d95d494c9be1/layout/style/res/forms.css#L728-L737)
*/

:-moz-ui-invalid {
  box-shadow: none;
}

/*
Add the correct vertical alignment in Chrome and Firefox.
*/

progress {
  vertical-align: baseline;
}

/*
Correct the cursor style of increment and decrement buttons in Safari.
*/

::-webkit-inner-spin-button,
::-webkit-outer-spin-button {
  height: auto;
}

/*
1. Correct the odd appearance in Chrome and Safari.
2. Correct the outline style in Safari.
*/

[type='search'] {
  -webkit-appearance: textfield;
  /* 1 */
  outline-offset: -2px;
  /* 2 */
}

/*
Remove the inner padding in Chrome and Safari on macOS.
*/

::-webkit-search-decoration {
  -webkit-appearance: none;
}

/*
1. Correct the inability to style clickable types in iOS and Safari.
2. Change font properties to `inherit` in Safari.
*/

::-webkit-file-upload-button {
  -webkit-appearance: button;
  /* 1 */
  font: inherit;
  /* 2 */
}

/*
Add the correct display in Chrome and Safari.
*/

summary {
  display: list-item;
}

/*
Removes the default spacing and border for appropriate elements.
*/

blockquote,
dl,
dd,
h1,
h2,
h3,
h4,
h5,
h6,
hr,
figure,
p,
pre {
  margin: 0;
}

fieldset {
  margin: 0;
  padding: 0;
}

legend {
  padding: 0;
}

ol,
ul,
menu {
  list-style: none;
  margin: 0;
  padding: 0;
}

/*
Prevent resizing textareas horizontally by default.
*/

textarea {
  resize: vertical;
}

/*
1. Reset the default placeholder opacity in Firefox. (https://github.com/tailwindlabs/tailwindcss/issues/3300)
2. Set the default placeholder color to the user's configured gray 400 color.
*/

input::-moz-placeholder, textarea::-moz-placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

input::placeholder,
textarea::placeholder {
  opacity: 1;
  /* 1 */
  color: #9ca3af;
  /* 2 */
}

/*
Set the default cursor for buttons.
*/

button,
[role="button"] {
  cursor: pointer;
}

/*
Make sure disabled buttons don't get the pointer cursor.
*/

:disabled {
  cursor: default;
}

/*
1. Make replaced elements `display: block` by default. (https://github.com/mozdevs/cssremedy/issues/14)
2. Add `vertical-align: middle` to align replaced elements more sensibly by default. (https://github.com/jensimmons/cssremedy/issues/14#issuecomment-634934210)
   This can trigger a poorly considered lint error in some tools but is included by design.
*/

img,
svg,
video,
canvas,
audio,
iframe,
embed,
object {
  display: block;
  /* 1 */
  vertical-align: middle;
  /* 2 */
}

/*
Constrain images and videos to the parent width and preserve their intrinsic aspect ratio. (https://github.com/mozdevs/cssremedy/issues/14)
*/

img,
video {
  max-width: 100%;
  height: auto;
}

/* Make elements with the HTML hidden attribute stay hidden by default */

[hidden] {
  display: none;
}

*, ::before, ::after {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

::backdrop {
  --tw-border-spacing-x: 0;
  --tw-border-spacing-y: 0;
  --tw-translate-x: 0;
  --tw-translate-y: 0;
  --tw-rotate: 0;
  --tw-skew-x: 0;
  --tw-skew-y: 0;
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  --tw-pan-x:  ;
  --tw-pan-y:  ;
  --tw-pinch-zoom:  ;
  --tw-scroll-snap-strictness: proximity;
  --tw-ordinal:  ;
  --tw-slashed-zero:  ;
  --tw-numeric-figure:  ;
  --tw-numeric-spacing:  ;
  --tw-numeric-fraction:  ;
  --tw-ring-inset:  ;
  --tw-ring-offset-width: 0px;
  --tw-ring-offset-color: #fff;
  --tw-ring-color: rgb(59 130 246 / 0.5);
  --tw-ring-offset-shadow: 0 0 #0000;
  --tw-ring-shadow: 0 0 #0000;
  --tw-shadow: 0 0 #0000;
  --tw-shadow-colored: 0 0 #0000;
  --tw-blur:  ;
  --tw-brightness:  ;
  --tw-contrast:  ;
  --tw-grayscale:  ;
  --tw-hue-rotate:  ;
  --tw-invert:  ;
  --tw-saturate:  ;
  --tw-sepia:  ;
  --tw-drop-shadow:  ;
  --tw-backdrop-blur:  ;
  --tw-backdrop-brightness:  ;
  --tw-backdrop-contrast:  ;
  --tw-backdrop-grayscale:  ;
  --tw-backdrop-hue-rotate:  ;
  --tw-backdrop-invert:  ;
  --tw-backdrop-opacity:  ;
  --tw-backdrop-saturate:  ;
  --tw-backdrop-sepia:  ;
}

.container {
  width: 100%;
}

@media (min-width: 640px) {
  .container {
    max-width: 640px;
  }
}

@media (min-width: 768px) {
  .container {
    max-width: 768px;
  }
}

@media (min-width: 1024px) {
  .container {
    max-width: 1024px;
  }
}

@media (min-width: 1280px) {
  .container {
    max-width: 1280px;
  }
}

@media (min-width: 1536px) {
  .container {
    max-width: 1536px;
  }
}

.pointer-events-none {
  pointer-events: none;
}

.visible {
  visibility: visible;
}

.invisible {
  visibility: hidden;
}

.collapse {
  visibility: collapse;
}

.static {
  position: static;
}

.fixed {
  position: fixed;
}

.absolute {
  position: absolute;
}

.\!relative {
  position: relative !important;
}

.relative {
  position: relative;
}

.sticky {
  position: sticky;
}

.inset-0 {
  top: 0px;
  right: 0px;
  bottom: 0px;
  left: 0px;
}

.bottom-0 {
  bottom: 0px;
}

.bottom-3 {
  bottom: 0.75rem;
}

.left-\[50\%\] {
  left: 50%;
}

.right-0 {
  right: 0px;
}

.right-3 {
  right: 0.75rem;
}

.right-\[10px\] {
  right: 10px;
}

.top-0 {
  top: 0px;
}

.top-3 {
  top: 0.75rem;
}

.top-8 {
  top: 2rem;
}

.top-\[10px\] {
  top: 10px;
}

.top-\[50\%\] {
  top: 50%;
}

.z-50 {
  z-index: 50;
}

.z-\[100\] {
  z-index: 100;
}

.z-\[101\] {
  z-index: 101;
}

.z-\[104\] {
  z-index: 104;
}

.z-\[105\] {
  z-index: 105;
}

.z-\[120\] {
  z-index: 120;
}

.z-\[98\] {
  z-index: 98;
}

.z-\[99\] {
  z-index: 99;
}

.order-1 {
  order: 1;
}

.order-2 {
  order: 2;
}

.order-3 {
  order: 3;
}

.col-span-2 {
  grid-column: span 2 / span 2;
}

.col-span-3 {
  grid-column: span 3 / span 3;
}

.col-span-7 {
  grid-column: span 7 / span 7;
}

.m-1 {
  margin: 0.25rem;
}

.m-2 {
  margin: 0.5rem;
}

.m-3 {
  margin: 0.75rem;
}

.m-auto {
  margin: auto;
}

.mx-2 {
  margin-left: 0.5rem;
  margin-right: 0.5rem;
}

.mx-4 {
  margin-left: 1rem;
  margin-right: 1rem;
}

.mx-5 {
  margin-left: 1.25rem;
  margin-right: 1.25rem;
}

.mx-auto {
  margin-left: auto;
  margin-right: auto;
}

.my-2 {
  margin-top: 0.5rem;
  margin-bottom: 0.5rem;
}

.my-3 {
  margin-top: 0.75rem;
  margin-bottom: 0.75rem;
}

.my-4 {
  margin-top: 1rem;
  margin-bottom: 1rem;
}

.my-8 {
  margin-top: 2rem;
  margin-bottom: 2rem;
}

.-ml-1 {
  margin-left: -0.25rem;
}

.mb-0 {
  margin-bottom: 0px;
}

.mb-1 {
  margin-bottom: 0.25rem;
}

.mb-2 {
  margin-bottom: 0.5rem;
}

.mb-4 {
  margin-bottom: 1rem;
}

.mb-6 {
  margin-bottom: 1.5rem;
}

.mb-8 {
  margin-bottom: 2rem;
}

.ml-2 {
  margin-left: 0.5rem;
}

.ml-20 {
  margin-left: 5rem;
}

.ml-4 {
  margin-left: 1rem;
}

.ml-5 {
  margin-left: 1.25rem;
}

.ml-6 {
  margin-left: 1.5rem;
}

.mr-4 {
  margin-right: 1rem;
}

.mr-5 {
  margin-right: 1.25rem;
}

.mt-0 {
  margin-top: 0px;
}

.mt-1 {
  margin-top: 0.25rem;
}

.mt-2 {
  margin-top: 0.5rem;
}

.mt-20 {
  margin-top: 5rem;
}

.mt-3 {
  margin-top: 0.75rem;
}

.mt-4 {
  margin-top: 1rem;
}

.mt-5 {
  margin-top: 1.25rem;
}

.mt-6 {
  margin-top: 1.5rem;
}

.mt-7 {
  margin-top: 1.75rem;
}

.mt-8 {
  margin-top: 2rem;
}

.mt-\[1px\] {
  margin-top: 1px;
}

.mt-\[30px\] {
  margin-top: 30px;
}

.box-border {
  box-sizing: border-box;
}

.block {
  display: block;
}

.inline-block {
  display: inline-block;
}

.inline {
  display: inline;
}

.flex {
  display: flex;
}

.inline-flex {
  display: inline-flex;
}

.table {
  display: table;
}

.inline-table {
  display: inline-table;
}

.table-caption {
  display: table-caption;
}

.table-cell {
  display: table-cell;
}

.table-column {
  display: table-column;
}

.table-column-group {
  display: table-column-group;
}

.table-footer-group {
  display: table-footer-group;
}

.table-header-group {
  display: table-header-group;
}

.table-row-group {
  display: table-row-group;
}

.table-row {
  display: table-row;
}

.flow-root {
  display: flow-root;
}

.grid {
  display: grid;
}

.inline-grid {
  display: inline-grid;
}

.contents {
  display: contents;
}

.list-item {
  display: list-item;
}

.hidden {
  display: none;
}

.aspect-square {
  aspect-ratio: 1 / 1;
}

.aspect-video {
  aspect-ratio: 16 / 9;
}

.h-1 {
  height: 0.25rem;
}

.h-10 {
  height: 2.5rem;
}

.h-11 {
  height: 2.75rem;
}

.h-12 {
  height: 3rem;
}

.h-3 {
  height: 0.75rem;
}

.h-32 {
  height: 8rem;
}

.h-4 {
  height: 1rem;
}

.h-40 {
  height: 10rem;
}

.h-44 {
  height: 11rem;
}

.h-6 {
  height: 1.5rem;
}

.h-8 {
  height: 2rem;
}

.h-80 {
  height: 20rem;
}

.h-96 {
  height: 24rem;
}

.h-\[14px\] {
  height: 14px;
}

.h-\[15px\] {
  height: 15px;
}

.h-\[16px\] {
  height: 16px;
}

.h-\[18px\] {
  height: 18px;
}

.h-\[1px\] {
  height: 1px;
}

.h-\[20px\] {
  height: 20px;
}

.h-\[2px\] {
  height: 2px;
}

.h-\[30px\] {
  height: 30px;
}

.h-\[33px\] {
  height: 33px;
}

.h-\[3px\] {
  height: 3px;
}

.h-\[40px\] {
  height: 40px;
}

.h-\[48px\] {
  height: 48px;
}

.h-\[4px\] {
  height: 4px;
}

.h-\[50px\] {
  height: 50px;
}

.h-\[51px\] {
  height: 51px;
}

.h-\[5px\] {
  height: 5px;
}

.h-\[60\%\] {
  height: 60%;
}

.h-\[60px\] {
  height: 60px;
}

.h-\[6px\] {
  height: 6px;
}

.h-\[70\%\] {
  height: 70%;
}

.h-\[70vh\] {
  height: 70vh;
}

.h-\[75vh\] {
  height: 75vh;
}

.h-\[80\%\] {
  height: 80%;
}

.h-\[80vh\] {
  height: 80vh;
}

.h-\[90\%\] {
  height: 90%;
}

.h-auto {
  height: auto;
}

.h-fit {
  height: -moz-fit-content;
  height: fit-content;
}

.h-full {
  height: 100%;
}

.h-screen {
  height: 100vh;
}

.max-h-\[40vh\] {
  max-height: 40vh;
}

.max-h-\[90\%\] {
  max-height: 90%;
}

.min-h-screen {
  min-height: 100vh;
}

.w-1 {
  width: 0.25rem;
}

.w-1\/2 {
  width: 50%;
}

.w-10 {
  width: 2.5rem;
}

.w-12 {
  width: 3rem;
}

.w-16 {
  width: 4rem;
}

.w-2 {
  width: 0.5rem;
}

.w-20 {
  width: 5rem;
}

.w-24 {
  width: 6rem;
}

.w-28 {
  width: 7rem;
}

.w-3 {
  width: 0.75rem;
}

.w-4 {
  width: 1rem;
}

.w-6 {
  width: 1.5rem;
}

.w-8 {
  width: 2rem;
}

.w-\[10\%\] {
  width: 10%;
}

.w-\[10px\] {
  width: 10px;
}

.w-\[11px\] {
  width: 11px;
}

.w-\[12\%\] {
  width: 12%;
}

.w-\[120px\] {
  width: 120px;
}

.w-\[13px\] {
  width: 13px;
}

.w-\[15\%\] {
  width: 15%;
}

.w-\[150px\] {
  width: 150px;
}

.w-\[15px\] {
  width: 15px;
}

.w-\[17px\] {
  width: 17px;
}

.w-\[18\%\] {
  width: 18%;
}

.w-\[18px\] {
  width: 18px;
}

.w-\[19\%\] {
  width: 19%;
}

.w-\[20\%\] {
  width: 20%;
}

.w-\[20px\] {
  width: 20px;
}

.w-\[22px\] {
  width: 22px;
}

.w-\[23px\] {
  width: 23px;
}

.w-\[25\%\] {
  width: 25%;
}

.w-\[27px\] {
  width: 27px;
}

.w-\[2px\] {
  width: 2px;
}

.w-\[3\%\] {
  width: 3%;
}

.w-\[30\%\] {
  width: 30%;
}

.w-\[30px\] {
  width: 30px;
}

.w-\[30vw\] {
  width: 30vw;
}

.w-\[330px\] {
  width: 330px;
}

.w-\[34\%\] {
  width: 34%;
}

.w-\[35\%\] {
  width: 35%;
}

.w-\[35px\] {
  width: 35px;
}

.w-\[40\%\] {
  width: 40%;
}

.w-\[46px\] {
  width: 46px;
}

.w-\[5\%\] {
  width: 5%;
}

.w-\[50\%\] {
  width: 50%;
}

.w-\[50px\] {
  width: 50px;
}

.w-\[51px\] {
  width: 51px;
}

.w-\[53\%\] {
  width: 53%;
}

.w-\[55\%\] {
  width: 55%;
}

.w-\[60\%\] {
  width: 60%;
}

.w-\[60px\] {
  width: 60px;
}

.w-\[65\%\] {
  width: 65%;
}

.w-\[65px\] {
  width: 65px;
}

.w-\[7\%\] {
  width: 7%;
}

.w-\[70\%\] {
  width: 70%;
}

.w-\[70px\] {
  width: 70px;
}

.w-\[8\%\] {
  width: 8%;
}

.w-\[80\%\] {
  width: 80%;
}

.w-\[80px\] {
  width: 80px;
}

.w-\[85\%\] {
  width: 85%;
}

.w-\[8px\] {
  width: 8px;
}

.w-\[9\%\] {
  width: 9%;
}

.w-\[90\%\] {
  width: 90%;
}

.w-\[95\%\] {
  width: 95%;
}

.w-fit {
  width: -moz-fit-content;
  width: fit-content;
}

.w-full {
  width: 100%;
}

.w-screen {
  width: 100vw;
}

.min-w-\[150px\] {
  min-width: 150px;
}

.min-w-\[600px\] {
  min-width: 600px;
}

.min-w-\[80px\] {
  min-width: 80px;
}

.max-w-\[150px\] {
  max-width: 150px;
}

.max-w-\[400px\] {
  max-width: 400px;
}

.max-w-\[450px\] {
  max-width: 450px;
}

.max-w-\[600px\] {
  max-width: 600px;
}

.max-w-\[80px\] {
  max-width: 80px;
}

.max-w-md {
  max-width: 28rem;
}

.flex-none {
  flex: none;
}

.flex-grow {
  flex-grow: 1;
}

.grow {
  flex-grow: 1;
}

.border-separate {
  border-collapse: separate;
}

.border-spacing-y-2 {
  --tw-border-spacing-y: 0.5rem;
  border-spacing: var(--tw-border-spacing-x) var(--tw-border-spacing-y);
}

.border-spacing-y-4 {
  --tw-border-spacing-y: 1rem;
  border-spacing: var(--tw-border-spacing-x) var(--tw-border-spacing-y);
}

.origin-center {
  transform-origin: center;
}

.-translate-x-\[50\%\] {
  --tw-translate-x: -50%;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.-translate-y-\[50\%\] {
  --tw-translate-y: -50%;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.translate-x-0 {
  --tw-translate-x: 0px;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.translate-x-20 {
  --tw-translate-x: 5rem;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.translate-x-\[115px\] {
  --tw-translate-x: 115px;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.translate-x-\[45px\] {
  --tw-translate-x: 45px;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.translate-x-\[76px\] {
  --tw-translate-x: 76px;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.rotate-180 {
  --tw-rotate: 180deg;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.scale-0 {
  --tw-scale-x: 0;
  --tw-scale-y: 0;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.scale-100 {
  --tw-scale-x: 1;
  --tw-scale-y: 1;
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.transform {
  transform: translate(var(--tw-translate-x), var(--tw-translate-y)) rotate(var(--tw-rotate)) skewX(var(--tw-skew-x)) skewY(var(--tw-skew-y)) scaleX(var(--tw-scale-x)) scaleY(var(--tw-scale-y));
}

.cursor-default {
  cursor: default;
}

.cursor-pointer {
  cursor: pointer;
}

.resize {
  resize: both;
}

.appearance-none {
  -webkit-appearance: none;
     -moz-appearance: none;
          appearance: none;
}

.grid-cols-10 {
  grid-template-columns: repeat(10, minmax(0, 1fr));
}

.grid-cols-3 {
  grid-template-columns: repeat(3, minmax(0, 1fr));
}

.flex-row {
  flex-direction: row;
}

.flex-col {
  flex-direction: column;
}

.flex-col-reverse {
  flex-direction: column-reverse;
}

.flex-wrap {
  flex-wrap: wrap;
}

.flex-nowrap {
  flex-wrap: nowrap;
}

.items-start {
  align-items: flex-start;
}

.items-center {
  align-items: center;
}

.justify-start {
  justify-content: flex-start;
}

.justify-end {
  justify-content: flex-end;
}

.justify-center {
  justify-content: center;
}

.justify-between {
  justify-content: space-between;
}

.justify-evenly {
  justify-content: space-evenly;
}

.gap-0 {
  gap: 0px;
}

.gap-1 {
  gap: 0.25rem;
}

.gap-2 {
  gap: 0.5rem;
}

.gap-3 {
  gap: 0.75rem;
}

.gap-4 {
  gap: 1rem;
}

.gap-5 {
  gap: 1.25rem;
}

.overflow-auto {
  overflow: auto;
}

.overflow-hidden {
  overflow: hidden;
}

.overflow-x-auto {
  overflow-x: auto;
}

.overflow-y-auto {
  overflow-y: auto;
}

.overflow-y-hidden {
  overflow-y: hidden;
}

.overflow-x-scroll {
  overflow-x: scroll;
}

.truncate {
  overflow: hidden;
  text-overflow: ellipsis;
  white-space: nowrap;
}

.text-ellipsis {
  text-overflow: ellipsis;
}

.whitespace-nowrap {
  white-space: nowrap;
}

.break-all {
  word-break: break-all;
}

.rounded {
  border-radius: 0.25rem;
}

.rounded-\[5px\] {
  border-radius: 5px;
}

.rounded-full {
  border-radius: 9999px;
}

.rounded-lg {
  border-radius: 0.5rem;
}

.rounded-md {
  border-radius: 0.375rem;
}

.rounded-sm {
  border-radius: 0.125rem;
}

.rounded-l-md {
  border-top-left-radius: 0.375rem;
  border-bottom-left-radius: 0.375rem;
}

.rounded-r-md {
  border-top-right-radius: 0.375rem;
  border-bottom-right-radius: 0.375rem;
}

.border {
  border-width: 1px;
}

.border-0 {
  border-width: 0px;
}

.border-2 {
  border-width: 2px;
}

.border-\[1px\] {
  border-width: 1px;
}

.border-\[2px\] {
  border-width: 2px;
}

.border-y-\[1px\] {
  border-top-width: 1px;
  border-bottom-width: 1px;
}

.border-b-2 {
  border-bottom-width: 2px;
}

.border-b-\[1px\] {
  border-bottom-width: 1px;
}

.border-l-\[1px\] {
  border-left-width: 1px;
}

.border-r-\[1px\] {
  border-right-width: 1px;
}

.border-t-\[1px\] {
  border-top-width: 1px;
}

.border-dashed {
  border-style: dashed;
}

.border-dotted {
  border-style: dotted;
}

.border-\[\#A7A5A5\] {
  --tw-border-opacity: 1;
  border-color: rgb(167 165 165 / var(--tw-border-opacity));
}

.border-\[\#C9C9C9\] {
  --tw-border-opacity: 1;
  border-color: rgb(201 201 201 / var(--tw-border-opacity));
}

.border-\[\#CCCCCC\] {
  --tw-border-opacity: 1;
  border-color: rgb(204 204 204 / var(--tw-border-opacity));
}

.border-\[\#D9D9D9\] {
  --tw-border-opacity: 1;
  border-color: rgb(217 217 217 / var(--tw-border-opacity));
}

.border-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.border-\[\#DDDDDD\] {
  --tw-border-opacity: 1;
  border-color: rgb(221 221 221 / var(--tw-border-opacity));
}

.border-\[\#F2F2F2\] {
  --tw-border-opacity: 1;
  border-color: rgb(242 242 242 / var(--tw-border-opacity));
}

.border-\[\#FFB015\] {
  --tw-border-opacity: 1;
  border-color: rgb(255 176 21 / var(--tw-border-opacity));
}

.border-y-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-top-color: rgb(220 218 218 / var(--tw-border-opacity));
  border-bottom-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.border-b-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-bottom-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.border-l-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-left-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.border-r-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-right-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.border-t-\[\#DCDADA\] {
  --tw-border-opacity: 1;
  border-top-color: rgb(220 218 218 / var(--tw-border-opacity));
}

.bg-\[\#000000\] {
  --tw-bg-opacity: 1;
  background-color: rgb(0 0 0 / var(--tw-bg-opacity));
}

.bg-\[\#222222\] {
  --tw-bg-opacity: 1;
  background-color: rgb(34 34 34 / var(--tw-bg-opacity));
}

.bg-\[\#3C3C3C\] {
  --tw-bg-opacity: 1;
  background-color: rgb(60 60 60 / var(--tw-bg-opacity));
}

.bg-\[\#535353\] {
  --tw-bg-opacity: 1;
  background-color: rgb(83 83 83 / var(--tw-bg-opacity));
}

.bg-\[\#6F6F6F\] {
  --tw-bg-opacity: 1;
  background-color: rgb(111 111 111 / var(--tw-bg-opacity));
}

.bg-\[\#CACACA\] {
  --tw-bg-opacity: 1;
  background-color: rgb(202 202 202 / var(--tw-bg-opacity));
}

.bg-\[\#DCDADA\] {
  --tw-bg-opacity: 1;
  background-color: rgb(220 218 218 / var(--tw-bg-opacity));
}

.bg-\[\#DDDDDD\] {
  --tw-bg-opacity: 1;
  background-color: rgb(221 221 221 / var(--tw-bg-opacity));
}

.bg-\[\#F2F2F2\] {
  --tw-bg-opacity: 1;
  background-color: rgb(242 242 242 / var(--tw-bg-opacity));
}

.bg-\[\#F7F7F7\] {
  --tw-bg-opacity: 1;
  background-color: rgb(247 247 247 / var(--tw-bg-opacity));
}

.bg-\[\#F9F2E4\] {
  --tw-bg-opacity: 1;
  background-color: rgb(249 242 228 / var(--tw-bg-opacity));
}

.bg-\[\#FFB015\] {
  --tw-bg-opacity: 1;
  background-color: rgb(255 176 21 / var(--tw-bg-opacity));
}

.bg-\[\#FFF6E3\] {
  --tw-bg-opacity: 1;
  background-color: rgb(255 246 227 / var(--tw-bg-opacity));
}

.bg-\[\#ffffff\] {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-black {
  --tw-bg-opacity: 1;
  background-color: rgb(0 0 0 / var(--tw-bg-opacity));
}

.bg-gray-100 {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}

.bg-primary {
  --tw-bg-opacity: 1;
  background-color: rgb(255 176 21 / var(--tw-bg-opacity));
}

.bg-red-400 {
  --tw-bg-opacity: 1;
  background-color: rgb(248 113 113 / var(--tw-bg-opacity));
}

.bg-white {
  --tw-bg-opacity: 1;
  background-color: rgb(255 255 255 / var(--tw-bg-opacity));
}

.bg-yellow-300 {
  --tw-bg-opacity: 1;
  background-color: rgb(253 224 71 / var(--tw-bg-opacity));
}

.fill-\[\#696969\] {
  fill: #696969;
}

.fill-\[\#9e9e9e\] {
  fill: #9e9e9e;
}

.fill-\[\#FFB015\] {
  fill: #FFB015;
}

.fill-black {
  fill: #000;
}

.fill-white {
  fill: #fff;
}

.object-cover {
  -o-object-fit: cover;
     object-fit: cover;
}

.p-1 {
  padding: 0.25rem;
}

.p-2 {
  padding: 0.5rem;
}

.p-3 {
  padding: 0.75rem;
}

.p-4 {
  padding: 1rem;
}

.p-5 {
  padding: 1.25rem;
}

.px-1 {
  padding-left: 0.25rem;
  padding-right: 0.25rem;
}

.px-2 {
  padding-left: 0.5rem;
  padding-right: 0.5rem;
}

.px-3 {
  padding-left: 0.75rem;
  padding-right: 0.75rem;
}

.px-4 {
  padding-left: 1rem;
  padding-right: 1rem;
}

.px-5 {
  padding-left: 1.25rem;
  padding-right: 1.25rem;
}

.px-6 {
  padding-left: 1.5rem;
  padding-right: 1.5rem;
}

.px-8 {
  padding-left: 2rem;
  padding-right: 2rem;
}

.px-\[10px\] {
  padding-left: 10px;
  padding-right: 10px;
}

.px-\[20px\] {
  padding-left: 20px;
  padding-right: 20px;
}

.py-1 {
  padding-top: 0.25rem;
  padding-bottom: 0.25rem;
}

.py-2 {
  padding-top: 0.5rem;
  padding-bottom: 0.5rem;
}

.py-3 {
  padding-top: 0.75rem;
  padding-bottom: 0.75rem;
}

.py-4 {
  padding-top: 1rem;
  padding-bottom: 1rem;
}

.py-6 {
  padding-top: 1.5rem;
  padding-bottom: 1.5rem;
}

.py-8 {
  padding-top: 2rem;
  padding-bottom: 2rem;
}

.py-\[1px\] {
  padding-top: 1px;
  padding-bottom: 1px;
}

.pb-10 {
  padding-bottom: 2.5rem;
}

.pb-4 {
  padding-bottom: 1rem;
}

.pb-5 {
  padding-bottom: 1.25rem;
}

.pb-8 {
  padding-bottom: 2rem;
}

.pl-0 {
  padding-left: 0px;
}

.pl-2 {
  padding-left: 0.5rem;
}

.pl-3 {
  padding-left: 0.75rem;
}

.pl-4 {
  padding-left: 1rem;
}

.pl-8 {
  padding-left: 2rem;
}

.pr-2 {
  padding-right: 0.5rem;
}

.pr-3 {
  padding-right: 0.75rem;
}

.pr-4 {
  padding-right: 1rem;
}

.pr-5 {
  padding-right: 1.25rem;
}

.pr-6 {
  padding-right: 1.5rem;
}

.pt-1 {
  padding-top: 0.25rem;
}

.pt-4 {
  padding-top: 1rem;
}

.pt-\[60px\] {
  padding-top: 60px;
}

.text-left {
  text-align: left;
}

.text-center {
  text-align: center;
}

.text-right {
  text-align: right;
}

.text-start {
  text-align: start;
}

.text-end {
  text-align: end;
}

.text-2xl {
  font-size: 1.5rem;
  line-height: 2rem;
}

.text-\[10px\] {
  font-size: 10px;
}

.text-\[11px\] {
  font-size: 11px;
}

.text-\[12px\] {
  font-size: 12px;
}

.text-\[14px\] {
  font-size: 14px;
}

.text-\[15px\] {
  font-size: 15px;
}

.text-\[25px\] {
  font-size: 25px;
}

.text-\[8px\] {
  font-size: 8px;
}

.text-lg {
  font-size: 1.125rem;
  line-height: 1.75rem;
}

.text-sm {
  font-size: 0.875rem;
  line-height: 1.25rem;
}

.text-xs {
  font-size: 0.75rem;
  line-height: 1rem;
}

.font-bold {
  font-weight: 700;
}

.font-medium {
  font-weight: 500;
}

.font-semibold {
  font-weight: 600;
}

.uppercase {
  text-transform: uppercase;
}

.lowercase {
  text-transform: lowercase;
}

.capitalize {
  text-transform: capitalize;
}

.italic {
  font-style: italic;
}

.ordinal {
  --tw-ordinal: ordinal;
  font-variant-numeric: var(--tw-ordinal) var(--tw-slashed-zero) var(--tw-numeric-figure) var(--tw-numeric-spacing) var(--tw-numeric-fraction);
}

.leading-none {
  line-height: 1;
}

.tracking-wide {
  letter-spacing: 0.025em;
}

.text-\[\#097E62\] {
  --tw-text-opacity: 1;
  color: rgb(9 126 98 / var(--tw-text-opacity));
}

.text-\[\#2c2c2c\] {
  --tw-text-opacity: 1;
  color: rgb(44 44 44 / var(--tw-text-opacity));
}

.text-\[\#357800\] {
  --tw-text-opacity: 1;
  color: rgb(53 120 0 / var(--tw-text-opacity));
}

.text-\[\#535353\] {
  --tw-text-opacity: 1;
  color: rgb(83 83 83 / var(--tw-text-opacity));
}

.text-\[\#565656\] {
  --tw-text-opacity: 1;
  color: rgb(86 86 86 / var(--tw-text-opacity));
}

.text-\[\#606060\] {
  --tw-text-opacity: 1;
  color: rgb(96 96 96 / var(--tw-text-opacity));
}

.text-\[\#787777\] {
  --tw-text-opacity: 1;
  color: rgb(120 119 119 / var(--tw-text-opacity));
}

.text-\[\#8F8F8F\] {
  --tw-text-opacity: 1;
  color: rgb(143 143 143 / var(--tw-text-opacity));
}

.text-\[\#9B9B9B\] {
  --tw-text-opacity: 1;
  color: rgb(155 155 155 / var(--tw-text-opacity));
}

.text-\[\#C68300\] {
  --tw-text-opacity: 1;
  color: rgb(198 131 0 / var(--tw-text-opacity));
}

.text-\[\#E20000\] {
  --tw-text-opacity: 1;
  color: rgb(226 0 0 / var(--tw-text-opacity));
}

.text-\[\#ff9215\] {
  --tw-text-opacity: 1;
  color: rgb(255 146 21 / var(--tw-text-opacity));
}

.text-black {
  --tw-text-opacity: 1;
  color: rgb(0 0 0 / var(--tw-text-opacity));
}

.text-gray-400 {
  --tw-text-opacity: 1;
  color: rgb(156 163 175 / var(--tw-text-opacity));
}

.text-gray-600 {
  --tw-text-opacity: 1;
  color: rgb(75 85 99 / var(--tw-text-opacity));
}

.text-gray-800 {
  --tw-text-opacity: 1;
  color: rgb(31 41 55 / var(--tw-text-opacity));
}

.text-primary {
  --tw-text-opacity: 1;
  color: rgb(255 176 21 / var(--tw-text-opacity));
}

.text-red-700 {
  --tw-text-opacity: 1;
  color: rgb(185 28 28 / var(--tw-text-opacity));
}

.text-red-900 {
  --tw-text-opacity: 1;
  color: rgb(127 29 29 / var(--tw-text-opacity));
}

.text-slate-200 {
  --tw-text-opacity: 1;
  color: rgb(226 232 240 / var(--tw-text-opacity));
}

.text-white {
  --tw-text-opacity: 1;
  color: rgb(255 255 255 / var(--tw-text-opacity));
}

.underline {
  text-decoration-line: underline;
}

.overline {
  text-decoration-line: overline;
}

.line-through {
  text-decoration-line: line-through;
}

.opacity-0 {
  opacity: 0;
}

.opacity-50 {
  opacity: 0.5;
}

.shadow {
  --tw-shadow: 0 1px 3px 0 rgb(0 0 0 / 0.1), 0 1px 2px -1px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 1px 3px 0 var(--tw-shadow-color), 0 1px 2px -1px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-lg {
  --tw-shadow: 0 10px 15px -3px rgb(0 0 0 / 0.1), 0 4px 6px -4px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 10px 15px -3px var(--tw-shadow-color), 0 4px 6px -4px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-md {
  --tw-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
  --tw-shadow-colored: 0 4px 6px -1px var(--tw-shadow-color), 0 2px 4px -2px var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.shadow-sm {
  --tw-shadow: 0 1px 2px 0 rgb(0 0 0 / 0.05);
  --tw-shadow-colored: 0 1px 2px 0 var(--tw-shadow-color);
  box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
}

.outline-none {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.outline {
  outline-style: solid;
}

.outline-0 {
  outline-width: 0px;
}

.outline-\[1px\] {
  outline-width: 1px;
}

.outline-\[\#DCDADA\] {
  outline-color: #DCDADA;
}

.blur {
  --tw-blur: blur(8px);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow-lg {
  --tw-drop-shadow: drop-shadow(0 10px 8px rgb(0 0 0 / 0.04)) drop-shadow(0 4px 3px rgb(0 0 0 / 0.1));
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow-md {
  --tw-drop-shadow: drop-shadow(0 4px 3px rgb(0 0 0 / 0.07)) drop-shadow(0 2px 2px rgb(0 0 0 / 0.06));
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.drop-shadow-sm {
  --tw-drop-shadow: drop-shadow(0 1px 1px rgb(0 0 0 / 0.05));
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.grayscale {
  --tw-grayscale: grayscale(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.invert {
  --tw-invert: invert(100%);
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.filter {
  filter: var(--tw-blur) var(--tw-brightness) var(--tw-contrast) var(--tw-grayscale) var(--tw-hue-rotate) var(--tw-invert) var(--tw-saturate) var(--tw-sepia) var(--tw-drop-shadow);
}

.transition {
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, -webkit-backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter;
  transition-property: color, background-color, border-color, text-decoration-color, fill, stroke, opacity, box-shadow, transform, filter, backdrop-filter, -webkit-backdrop-filter;
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
  transition-duration: 150ms;
}

.delay-300 {
  transition-delay: 300ms;
}

.delay-75 {
  transition-delay: 75ms;
}

.duration-200 {
  transition-duration: 200ms;
}

.duration-300 {
  transition-duration: 300ms;
}

.duration-500 {
  transition-duration: 500ms;
}

.ease-in {
  transition-timing-function: cubic-bezier(0.4, 0, 1, 1);
}

.ease-in-out {
  transition-timing-function: cubic-bezier(0.4, 0, 0.2, 1);
}

.ease-linear {
  transition-timing-function: linear;
}

.scrollbar-hide {
  -ms-overflow-style: none;
  scrollbar-width: none;
}

.scrollbar-hide::-webkit-scrollbar {
  display: none;
}

@font-face {
  font-family: "poppins-regular";

  src: url(../../assets/fonts/Poppins-Regular.ttf);
}

@font-face {
  font-family: "poppins-medium";

  src: url(../../assets/fonts/Poppins-Medium.ttf);
}

@font-face {
  font-family: "poppins-semibold";

  src: url(../../assets/fonts/Poppins-SemiBold.ttf);
}

@font-face {
  font-family: "poppins-bold";

  src: url(../../assets/fonts/Poppins-Bold.ttf);
}

body {
  box-sizing: border-box;
  padding: 0;
  margin: 0;
  font-family: 'poppins-regular', sans-serif;
}

/* font */

.poppins-regular {
  font-family: "poppins-regular" !important;
}

.poppins-medium {
  font-family: "poppins-medium" !important;
}

.poppins-semibold {
  font-family: "poppins-semibold" !important;
}

.poppins-bold {
  font-family: "poppins-bold" !important;
}

/* ============================ End coppy script dibawah kalo mau buat file input baru ============================ */

.text-selector-none{
  -webkit-user-select: none;
  /* Safari */
  /* IE 10 and IE 11 */
  -moz-user-select: none;
       user-select: none;
  /* Standard syntax */
}

/* sidebar */

.main-sidebar {
  transform: translateX(-100%) !important;
  transition: 1s;
}

.sidebar-show{
  transform: translateX(0%) !important;
  transition: 1s;
}

@media(min-width: 1024px) {
  .main-sidebar {
    transform: translateX(0%) !important;
    transition: 1s;
  }
}

#bg-sidebar{
  transition: 1s;
}

.menu:hover .menu-hover1 svg {
  fill: #946F27;
}

.menu:hover .menu-hover1 p {
  color: #946F27;
}

.menu:hover .menu-hover2 {
  background: #FFA900;
}

/* active */

.menu-active1 svg {
  fill: #FFA900;
}

.menu-active1 p {
  color: #FFA900;
}

.menu-active2 {
  background: #FFA900;
}

/* laporan pemasukan */

#menu_pemasukan1:hover div{
  background: #FFB015;
}

#menu_pemasukan2:hover div{
  background: #FFB015;
}

#menu_pemasukan3:hover div{
  background: #FFB015;
}

.loadingspinner {
  pointer-events: none;
  width: 2.5em;
  height: 2.5em;
  border: 0.4em solid transparent;
  border-color: #eee;
  border-top-color: #FFB015;
  border-radius: 50%;
  outline: none;
  animation: loadingspin 1s linear infinite;
}

@keyframes loadingspin {
  100% {
    transform: rotate(360deg)
  }
}

.body-loading {
  border: none;
  overflow: hidden;
  margin: 0;
  padding: 0;
  display: flex;
  justify-content: center;
  align-items: center;
}

.transition-masterdata {
  transition: ease-in-out 0.4s;
}

.placeholder\:text-\[11px\]::-moz-placeholder {
  font-size: 11px;
}

.placeholder\:text-\[11px\]::placeholder {
  font-size: 11px;
}

.placeholder\:text-\[15px\]::-moz-placeholder {
  font-size: 15px;
}

.placeholder\:text-\[15px\]::placeholder {
  font-size: 15px;
}

.placeholder\:text-\[\#b3b3b3\]::-moz-placeholder {
  --tw-text-opacity: 1;
  color: rgb(179 179 179 / var(--tw-text-opacity));
}

.placeholder\:text-\[\#b3b3b3\]::placeholder {
  --tw-text-opacity: 1;
  color: rgb(179 179 179 / var(--tw-text-opacity));
}

.hover\:border-b-2:hover {
  border-bottom-width: 2px;
}

.hover\:border-orange-500:hover {
  --tw-border-opacity: 1;
  border-color: rgb(249 115 22 / var(--tw-border-opacity));
}

.hover\:bg-\[\#292929\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(41 41 41 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#3b3b3b\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(59 59 59 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#FFB015\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(255 176 21 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#FFF6E3\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(255 246 227 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#ce8900\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(206 137 0 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#d48e00\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(212 142 0 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#e69900\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(230 153 0 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#e7a013\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(231 160 19 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#ebebeb\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(235 235 235 / var(--tw-bg-opacity));
}

.hover\:bg-\[\#f5a300\]:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(245 163 0 / var(--tw-bg-opacity));
}

.hover\:bg-black:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(0 0 0 / var(--tw-bg-opacity));
}

.hover\:bg-gray-100:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(243 244 246 / var(--tw-bg-opacity));
}

.hover\:bg-gray-200:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(229 231 235 / var(--tw-bg-opacity));
}

.hover\:bg-primary-hover:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(231 160 19 / var(--tw-bg-opacity));
}

.hover\:bg-slate-100:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(241 245 249 / var(--tw-bg-opacity));
}

.hover\:bg-slate-50:hover {
  --tw-bg-opacity: 1;
  background-color: rgb(248 250 252 / var(--tw-bg-opacity));
}

.hover\:fill-\[\#3a3a3a\]:hover {
  fill: #3a3a3a;
}

.hover\:fill-\[\#f1a100\]:hover {
  fill: #f1a100;
}

.hover\:text-\[\#ff9215\]:hover {
  --tw-text-opacity: 1;
  color: rgb(255 146 21 / var(--tw-text-opacity));
}

.hover\:text-gray-900:hover {
  --tw-text-opacity: 1;
  color: rgb(17 24 39 / var(--tw-text-opacity));
}

.focus\:outline-none:focus {
  outline: 2px solid transparent;
  outline-offset: 2px;
}

.group:hover .group-hover\:opacity-100 {
  opacity: 1;
}

@media not all and (min-width: 1024px) {
  .max-lg\:hidden {
    display: none;
  }

  .max-lg\:aspect-square {
    aspect-ratio: 1 / 1;
  }

  .max-lg\:items-center {
    align-items: center;
  }

  .max-lg\:gap-2 {
    gap: 0.5rem;
  }
}

@media not all and (min-width: 768px) {
  .max-md\:absolute {
    position: absolute;
  }

  .max-md\:right-3 {
    right: 0.75rem;
  }

  .max-md\:top-14 {
    top: 3.5rem;
  }

  .max-md\:z-20 {
    z-index: 20;
  }

  .max-md\:mt-6 {
    margin-top: 1.5rem;
  }

  .max-md\:hidden {
    display: none;
  }

  .max-md\:h-full {
    height: 100%;
  }

  .max-md\:w-\[120px\] {
    width: 120px;
  }

  .max-md\:border-\[1px\] {
    border-width: 1px;
  }

  .max-md\:border-\[2px\] {
    border-width: 2px;
  }

  .max-md\:border-b-\[1px\] {
    border-bottom-width: 1px;
  }

  .max-md\:border-\[\#DCDADA\] {
    --tw-border-opacity: 1;
    border-color: rgb(220 218 218 / var(--tw-border-opacity));
  }

  .max-md\:border-black {
    --tw-border-opacity: 1;
    border-color: rgb(0 0 0 / var(--tw-border-opacity));
  }

  .max-md\:border-b-\[\#DCDADA\] {
    --tw-border-opacity: 1;
    border-bottom-color: rgb(220 218 218 / var(--tw-border-opacity));
  }

  .max-md\:px-4 {
    padding-left: 1rem;
    padding-right: 1rem;
  }

  .max-md\:py-3 {
    padding-top: 0.75rem;
    padding-bottom: 0.75rem;
  }

  .max-md\:shadow-md {
    --tw-shadow: 0 4px 6px -1px rgb(0 0 0 / 0.1), 0 2px 4px -2px rgb(0 0 0 / 0.1);
    --tw-shadow-colored: 0 4px 6px -1px var(--tw-shadow-color), 0 2px 4px -2px var(--tw-shadow-color);
    box-shadow: var(--tw-ring-offset-shadow, 0 0 #0000), var(--tw-ring-shadow, 0 0 #0000), var(--tw-shadow);
  }
}

@media (min-width: 360px) {
  .min-\[360px\]\:right-4 {
    right: 1rem;
  }

  .min-\[360px\]\:right-\[14px\] {
    right: 14px;
  }

  .min-\[360px\]\:top-10 {
    top: 2.5rem;
  }

  .min-\[360px\]\:top-4 {
    top: 1rem;
  }

  .min-\[360px\]\:top-\[14px\] {
    top: 14px;
  }

  .min-\[360px\]\:h-14 {
    height: 3.5rem;
  }

  .min-\[360px\]\:h-\[45px\] {
    height: 45px;
  }

  .min-\[360px\]\:h-\[54px\] {
    height: 54px;
  }

  .min-\[360px\]\:w-32 {
    width: 8rem;
  }

  .min-\[360px\]\:w-\[90\%\] {
    width: 90%;
  }

  .min-\[360px\]\:gap-3 {
    gap: 0.75rem;
  }

  .min-\[360px\]\:gap-5 {
    gap: 1.25rem;
  }

  .min-\[360px\]\:rounded-\[5px\] {
    border-radius: 5px;
  }

  .min-\[360px\]\:p-3 {
    padding: 0.75rem;
  }

  .min-\[360px\]\:text-\[11px\] {
    font-size: 11px;
  }

  .min-\[360px\]\:text-\[12px\] {
    font-size: 12px;
  }

  .min-\[360px\]\:text-\[13px\] {
    font-size: 13px;
  }

  .min-\[360px\]\:text-\[25px\] {
    font-size: 25px;
  }

  .min-\[360px\]\:text-\[30px\] {
    font-size: 30px;
  }
}

@media (min-width: 374px) {
  .min-\[374px\]\:mb-2 {
    margin-bottom: 0.5rem;
  }

  .min-\[374px\]\:mb-3 {
    margin-bottom: 0.75rem;
  }

  .min-\[374px\]\:mt-4 {
    margin-top: 1rem;
  }

  .min-\[374px\]\:mt-9 {
    margin-top: 2.25rem;
  }

  .min-\[374px\]\:h-11 {
    height: 2.75rem;
  }

  .min-\[374px\]\:p-5 {
    padding: 1.25rem;
  }

  .min-\[374px\]\:px-5 {
    padding-left: 1.25rem;
    padding-right: 1.25rem;
  }
}

@media (min-width: 390px) {
  .min-\[390px\]\:text-base {
    font-size: 1rem;
    line-height: 1.5rem;
  }

  .min-\[390px\]\:text-sm {
    font-size: 0.875rem;
    line-height: 1.25rem;
  }
}

@media (min-width: 768px) {
  .md\:relative {
    position: relative;
  }

  .md\:right-5 {
    right: 1.25rem;
  }

  .md\:right-\[18px\] {
    right: 18px;
  }

  .md\:top-5 {
    top: 1.25rem;
  }

  .md\:top-\[18px\] {
    top: 18px;
  }

  .md\:order-1 {
    order: 1;
  }

  .md\:order-2 {
    order: 2;
  }

  .md\:order-3 {
    order: 3;
  }

  .md\:order-4 {
    order: 4;
  }

  .md\:order-5 {
    order: 5;
  }

  .md\:order-6 {
    order: 6;
  }

  .md\:order-7 {
    order: 7;
  }

  .md\:order-8 {
    order: 8;
  }

  .md\:col-span-2 {
    grid-column: span 2 / span 2;
  }

  .md\:col-span-8 {
    grid-column: span 8 / span 8;
  }

  .md\:mb-20 {
    margin-bottom: 5rem;
  }

  .md\:mb-8 {
    margin-bottom: 2rem;
  }

  .md\:ml-0 {
    margin-left: 0px;
  }

  .md\:ml-12 {
    margin-left: 3rem;
  }

  .md\:ml-4 {
    margin-left: 1rem;
  }

  .md\:ml-\[59px\] {
    margin-left: 59px;
  }

  .md\:mr-8 {
    margin-right: 2rem;
  }

  .md\:mt-0 {
    margin-top: 0px;
  }

  .md\:mt-10 {
    margin-top: 2.5rem;
  }

  .md\:mt-6 {
    margin-top: 1.5rem;
  }

  .md\:mt-8 {
    margin-top: 2rem;
  }

  .md\:mt-\[45px\] {
    margin-top: 45px;
  }

  .md\:flex {
    display: flex;
  }

  .md\:hidden {
    display: none;
  }

  .md\:h-14 {
    height: 3.5rem;
  }

  .md\:h-16 {
    height: 4rem;
  }

  .md\:h-4 {
    height: 1rem;
  }

  .md\:h-96 {
    height: 24rem;
  }

  .md\:h-\[18px\] {
    height: 18px;
  }

  .md\:h-\[20px\] {
    height: 20px;
  }

  .md\:h-\[21px\] {
    height: 21px;
  }

  .md\:h-\[26px\] {
    height: 26px;
  }

  .md\:h-\[30px\] {
    height: 30px;
  }

  .md\:h-\[43px\] {
    height: 43px;
  }

  .md\:h-\[50px\] {
    height: 50px;
  }

  .md\:h-\[60px\] {
    height: 60px;
  }

  .md\:h-\[6px\] {
    height: 6px;
  }

  .md\:h-\[70px\] {
    height: 70px;
  }

  .md\:h-full {
    height: 100%;
  }

  .md\:w-1\/2 {
    width: 50%;
  }

  .md\:w-14 {
    width: 3.5rem;
  }

  .md\:w-16 {
    width: 4rem;
  }

  .md\:w-32 {
    width: 8rem;
  }

  .md\:w-4 {
    width: 1rem;
  }

  .md\:w-52 {
    width: 13rem;
  }

  .md\:w-\[140px\] {
    width: 140px;
  }

  .md\:w-\[16px\] {
    width: 16px;
  }

  .md\:w-\[18px\] {
    width: 18px;
  }

  .md\:w-\[206px\] {
    width: 206px;
  }

  .md\:w-\[20px\] {
    width: 20px;
  }

  .md\:w-\[28px\] {
    width: 28px;
  }

  .md\:w-\[30\%\] {
    width: 30%;
  }

  .md\:w-\[30px\] {
    width: 30px;
  }

  .md\:w-\[310px\] {
    width: 310px;
  }

  .md\:w-\[32\%\] {
    width: 32%;
  }

  .md\:w-\[33px\] {
    width: 33px;
  }

  .md\:w-\[390px\] {
    width: 390px;
  }

  .md\:w-\[400px\] {
    width: 400px;
  }

  .md\:w-\[48\%\] {
    width: 48%;
  }

  .md\:w-\[50\%\] {
    width: 50%;
  }

  .md\:w-\[500px\] {
    width: 500px;
  }

  .md\:w-\[50px\] {
    width: 50px;
  }

  .md\:w-\[517px\] {
    width: 517px;
  }

  .md\:w-\[540px\] {
    width: 540px;
  }

  .md\:w-\[60\%\] {
    width: 60%;
  }

  .md\:w-\[662px\] {
    width: 662px;
  }

  .md\:w-\[70\%\] {
    width: 70%;
  }

  .md\:w-\[70px\] {
    width: 70px;
  }

  .md\:w-\[80\%\] {
    width: 80%;
  }

  .md\:w-\[90\%\] {
    width: 90%;
  }

  .md\:w-auto {
    width: auto;
  }

  .md\:w-fit {
    width: -moz-fit-content;
    width: fit-content;
  }

  .md\:w-full {
    width: 100%;
  }

  .md\:max-w-\[1350px\] {
    max-width: 1350px;
  }

  .md\:border-spacing-4 {
    --tw-border-spacing-x: 1rem;
    --tw-border-spacing-y: 1rem;
    border-spacing: var(--tw-border-spacing-x) var(--tw-border-spacing-y);
  }

  .md\:flex-row {
    flex-direction: row;
  }

  .md\:flex-col {
    flex-direction: column;
  }

  .md\:flex-wrap {
    flex-wrap: wrap;
  }

  .md\:items-end {
    align-items: flex-end;
  }

  .md\:justify-start {
    justify-content: flex-start;
  }

  .md\:justify-end {
    justify-content: flex-end;
  }

  .md\:justify-center {
    justify-content: center;
  }

  .md\:justify-between {
    justify-content: space-between;
  }

  .md\:gap-3 {
    gap: 0.75rem;
  }

  .md\:gap-4 {
    gap: 1rem;
  }

  .md\:gap-5 {
    gap: 1.25rem;
  }

  .md\:gap-6 {
    gap: 1.5rem;
  }

  .md\:gap-7 {
    gap: 1.75rem;
  }

  .md\:gap-9 {
    gap: 2.25rem;
  }

  .md\:overflow-x-hidden {
    overflow-x: hidden;
  }

  .md\:rounded-2xl {
    border-radius: 1rem;
  }

  .md\:rounded-lg {
    border-radius: 0.5rem;
  }

  .md\:border-b-0 {
    border-bottom-width: 0px;
  }

  .md\:border-r-\[1px\] {
    border-right-width: 1px;
  }

  .md\:p-0 {
    padding: 0px;
  }

  .md\:p-4 {
    padding: 1rem;
  }

  .md\:p-5 {
    padding: 1.25rem;
  }

  .md\:p-6 {
    padding: 1.5rem;
  }

  .md\:p-7 {
    padding: 1.75rem;
  }

  .md\:p-8 {
    padding: 2rem;
  }

  .md\:px-12 {
    padding-left: 3rem;
    padding-right: 3rem;
  }

  .md\:px-3 {
    padding-left: 0.75rem;
    padding-right: 0.75rem;
  }

  .md\:px-4 {
    padding-left: 1rem;
    padding-right: 1rem;
  }

  .md\:px-6 {
    padding-left: 1.5rem;
    padding-right: 1.5rem;
  }

  .md\:px-7 {
    padding-left: 1.75rem;
    padding-right: 1.75rem;
  }

  .md\:px-8 {
    padding-left: 2rem;
    padding-right: 2rem;
  }

  .md\:px-\[30px\] {
    padding-left: 30px;
    padding-right: 30px;
  }

  .md\:py-2 {
    padding-top: 0.5rem;
    padding-bottom: 0.5rem;
  }

  .md\:py-4 {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }

  .md\:pb-0 {
    padding-bottom: 0px;
  }

  .md\:pl-8 {
    padding-left: 2rem;
  }

  .md\:pr-7 {
    padding-right: 1.75rem;
  }

  .md\:pr-8 {
    padding-right: 2rem;
  }

  .md\:pt-0 {
    padding-top: 0px;
  }

  .md\:pt-8 {
    padding-top: 2rem;
  }

  .md\:pt-\[70px\] {
    padding-top: 70px;
  }

  .md\:text-center {
    text-align: center;
  }

  .md\:text-2xl {
    font-size: 1.5rem;
    line-height: 2rem;
  }

  .md\:text-\[14px\] {
    font-size: 14px;
  }

  .md\:text-\[15px\] {
    font-size: 15px;
  }

  .md\:text-\[16px\] {
    font-size: 16px;
  }

  .md\:text-\[17px\] {
    font-size: 17px;
  }

  .md\:text-\[18px\] {
    font-size: 18px;
  }

  .md\:text-\[20px\] {
    font-size: 20px;
  }

  .md\:text-\[40px\] {
    font-size: 40px;
  }

  .md\:text-base {
    font-size: 1rem;
    line-height: 1.5rem;
  }

  .md\:text-lg {
    font-size: 1.125rem;
    line-height: 1.75rem;
  }

  .md\:text-xl {
    font-size: 1.25rem;
    line-height: 1.75rem;
  }

  .md\:leading-\[45px\] {
    line-height: 45px;
  }

  .md\:scrollbar-hide {
    -ms-overflow-style: none;
    scrollbar-width: none;
  }

  .md\:scrollbar-hide::-webkit-scrollbar {
    display: none;
  }

  .md\:placeholder\:text-\[15px\]::-moz-placeholder {
    font-size: 15px;
  }

  .md\:placeholder\:text-\[15px\]::placeholder {
    font-size: 15px;
  }

  .md\:placeholder\:text-\[20px\]::-moz-placeholder {
    font-size: 20px;
  }

  .md\:placeholder\:text-\[20px\]::placeholder {
    font-size: 20px;
  }

  .md\:hover\:bg-\[\#FFB015\]:hover {
    --tw-bg-opacity: 1;
    background-color: rgb(255 176 21 / var(--tw-bg-opacity));
  }
}

@media (min-width: 1024px) {
  .lg\:right-\[16px\] {
    right: 16px;
  }

  .lg\:right-\[18px\] {
    right: 18px;
  }

  .lg\:top-\[16px\] {
    top: 16px;
  }

  .lg\:top-\[18px\] {
    top: 18px;
  }

  .lg\:m-0 {
    margin: 0px;
  }

  .lg\:-mt-20 {
    margin-top: -5rem;
  }

  .lg\:mb-0 {
    margin-bottom: 0px;
  }

  .lg\:ml-0 {
    margin-left: 0px;
  }

  .lg\:mt-0 {
    margin-top: 0px;
  }

  .lg\:mt-16 {
    margin-top: 4rem;
  }

  .lg\:mt-3 {
    margin-top: 0.75rem;
  }

  .lg\:mt-7 {
    margin-top: 1.75rem;
  }

  .lg\:mt-\[10\%\] {
    margin-top: 10%;
  }

  .lg\:mt-\[25px\] {
    margin-top: 25px;
  }

  .lg\:mt-\[5\%\] {
    margin-top: 5%;
  }

  .lg\:flex {
    display: flex;
  }

  .lg\:hidden {
    display: none;
  }

  .lg\:h-6 {
    height: 1.5rem;
  }

  .lg\:h-\[19px\] {
    height: 19px;
  }

  .lg\:h-\[24px\] {
    height: 24px;
  }

  .lg\:h-\[25px\] {
    height: 25px;
  }

  .lg\:h-\[30\%\] {
    height: 30%;
  }

  .lg\:h-\[40px\] {
    height: 40px;
  }

  .lg\:h-\[45\%\] {
    height: 45%;
  }

  .lg\:h-\[50px\] {
    height: 50px;
  }

  .lg\:h-\[525px\] {
    height: 525px;
  }

  .lg\:h-\[55px\] {
    height: 55px;
  }

  .lg\:h-\[65\%\] {
    height: 65%;
  }

  .lg\:h-\[65vh\] {
    height: 65vh;
  }

  .lg\:h-\[73vh\] {
    height: 73vh;
  }

  .lg\:h-\[80\%\] {
    height: 80%;
  }

  .lg\:h-\[80px\] {
    height: 80px;
  }

  .lg\:h-\[85\%\] {
    height: 85%;
  }

  .lg\:h-\[85vh\] {
    height: 85vh;
  }

  .lg\:h-\[95\%\] {
    height: 95%;
  }

  .lg\:h-full {
    height: 100%;
  }

  .lg\:h-screen {
    height: 100vh;
  }

  .lg\:min-h-full {
    min-height: 100%;
  }

  .lg\:w-1\/2 {
    width: 50%;
  }

  .lg\:w-12 {
    width: 3rem;
  }

  .lg\:w-6 {
    width: 1.5rem;
  }

  .lg\:w-8 {
    width: 2rem;
  }

  .lg\:w-\[136px\] {
    width: 136px;
  }

  .lg\:w-\[160px\] {
    width: 160px;
  }

  .lg\:w-\[20\%\] {
    width: 20%;
  }

  .lg\:w-\[25px\] {
    width: 25px;
  }

  .lg\:w-\[26px\] {
    width: 26px;
  }

  .lg\:w-\[290px\] {
    width: 290px;
  }

  .lg\:w-\[30\%\] {
    width: 30%;
  }

  .lg\:w-\[31px\] {
    width: 31px;
  }

  .lg\:w-\[33\%\] {
    width: 33%;
  }

  .lg\:w-\[35\%\] {
    width: 35%;
  }

  .lg\:w-\[40\%\] {
    width: 40%;
  }

  .lg\:w-\[40px\] {
    width: 40px;
  }

  .lg\:w-\[50\%\] {
    width: 50%;
  }

  .lg\:w-\[50px\] {
    width: 50px;
  }

  .lg\:w-\[60\%\] {
    width: 60%;
  }

  .lg\:w-\[65\%\] {
    width: 65%;
  }

  .lg\:w-\[70\%\] {
    width: 70%;
  }

  .lg\:w-\[75\%\] {
    width: 75%;
  }

  .lg\:w-\[80px\] {
    width: 80px;
  }

  .lg\:w-\[90\%\] {
    width: 90%;
  }

  .lg\:w-\[900px\] {
    width: 900px;
  }

  .lg\:w-full {
    width: 100%;
  }

  .lg\:border-spacing-2 {
    --tw-border-spacing-x: 0.5rem;
    --tw-border-spacing-y: 0.5rem;
    border-spacing: var(--tw-border-spacing-x) var(--tw-border-spacing-y);
  }

  .lg\:flex-row {
    flex-direction: row;
  }

  .lg\:flex-col {
    flex-direction: column;
  }

  .lg\:flex-col-reverse {
    flex-direction: column-reverse;
  }

  .lg\:items-start {
    align-items: flex-start;
  }

  .lg\:items-end {
    align-items: flex-end;
  }

  .lg\:items-center {
    align-items: center;
  }

  .lg\:justify-start {
    justify-content: flex-start;
  }

  .lg\:justify-end {
    justify-content: flex-end;
  }

  .lg\:justify-center {
    justify-content: center;
  }

  .lg\:justify-between {
    justify-content: space-between;
  }

  .lg\:gap-0 {
    gap: 0px;
  }

  .lg\:gap-4 {
    gap: 1rem;
  }

  .lg\:gap-5 {
    gap: 1.25rem;
  }

  .lg\:gap-7 {
    gap: 1.75rem;
  }

  .lg\:p-3 {
    padding: 0.75rem;
  }

  .lg\:p-5 {
    padding: 1.25rem;
  }

  .lg\:px-16 {
    padding-left: 4rem;
    padding-right: 4rem;
  }

  .lg\:px-7 {
    padding-left: 1.75rem;
    padding-right: 1.75rem;
  }

  .lg\:px-\[3\%\] {
    padding-left: 3%;
    padding-right: 3%;
  }

  .lg\:py-14 {
    padding-top: 3.5rem;
    padding-bottom: 3.5rem;
  }

  .lg\:py-4 {
    padding-top: 1rem;
    padding-bottom: 1rem;
  }

  .lg\:py-\[29px\] {
    padding-top: 29px;
    padding-bottom: 29px;
  }

  .lg\:pl-\[290px\] {
    padding-left: 290px;
  }

  .lg\:pl-\[40\%\] {
    padding-left: 40%;
  }

  .lg\:text-left {
    text-align: left;
  }

  .lg\:text-end {
    text-align: end;
  }

  .lg\:text-\[13px\] {
    font-size: 13px;
  }

  .lg\:text-\[15px\] {
    font-size: 15px;
  }

  .lg\:text-\[16px\] {
    font-size: 16px;
  }

  .lg\:text-\[17px\] {
    font-size: 17px;
  }

  .lg\:text-\[18px\] {
    font-size: 18px;
  }

  .lg\:text-\[30px\] {
    font-size: 30px;
  }

  .lg\:text-base {
    font-size: 1rem;
    line-height: 1.5rem;
  }

  .lg\:text-lg {
    font-size: 1.125rem;
    line-height: 1.75rem;
  }

  .lg\:placeholder\:text-\[17px\]::-moz-placeholder {
    font-size: 17px;
  }

  .lg\:placeholder\:text-\[17px\]::placeholder {
    font-size: 17px;
  }
}

@media (min-width: 1280px) {
  .xl\:-mt-32 {
    margin-top: -8rem;
  }

  .xl\:h-\[60px\] {
    height: 60px;
  }

  .xl\:h-\[63vh\] {
    height: 63vh;
  }

  .xl\:h-\[80px\] {
    height: 80px;
  }

  .xl\:h-\[88vh\] {
    height: 88vh;
  }

  .xl\:w-\[60px\] {
    width: 60px;
  }

  .xl\:w-\[80\%\] {
    width: 80%;
  }

  .xl\:gap-5 {
    gap: 1.25rem;
  }

  .xl\:p-4 {
    padding: 1rem;
  }

  .xl\:pt-\[80px\] {
    padding-top: 80px;
  }

  .xl\:text-\[32px\] {
    font-size: 32px;
  }
}

@media (min-width: 1481px) {
  .min-\[1481px\]\:w-\[28\%\] {
    width: 28%;
  }

  .min-\[1481px\]\:text-\[18px\] {
    font-size: 18px;
  }
}

@media (min-width: 1536px) {
  .\32xl\:right-6 {
    right: 1.5rem;
  }

  .\32xl\:right-\[22px\] {
    right: 22px;
  }

  .\32xl\:top-6 {
    top: 1.5rem;
  }

  .\32xl\:top-\[22px\] {
    top: 22px;
  }

  .\32xl\:mb-3 {
    margin-bottom: 0.75rem;
  }

  .\32xl\:h-24 {
    height: 6rem;
  }

  .\32xl\:h-\[22px\] {
    height: 22px;
  }

  .\32xl\:h-\[27px\] {
    height: 27px;
  }

  .\32xl\:h-\[30\%\] {
    height: 30%;
  }

  .\32xl\:h-\[70px\] {
    height: 70px;
  }

  .\32xl\:h-\[70vh\] {
    height: 70vh;
  }

  .\32xl\:h-\[75\%\] {
    height: 75%;
  }

  .\32xl\:h-\[79vh\] {
    height: 79vh;
  }

  .\32xl\:h-\[80px\] {
    height: 80px;
  }

  .\32xl\:h-\[85\%\] {
    height: 85%;
  }

  .\32xl\:h-auto {
    height: auto;
  }

  .\32xl\:w-\[29px\] {
    width: 29px;
  }

  .\32xl\:w-\[34px\] {
    width: 34px;
  }

  .\32xl\:w-\[35\%\] {
    width: 35%;
  }

  .\32xl\:w-\[50\%\] {
    width: 50%;
  }

  .\32xl\:w-\[70\%\] {
    width: 70%;
  }

  .\32xl\:w-\[75\%\] {
    width: 75%;
  }

  .\32xl\:w-\[80px\] {
    width: 80px;
  }

  .\32xl\:w-full {
    width: 100%;
  }

  .\32xl\:border-spacing-3 {
    --tw-border-spacing-x: 0.75rem;
    --tw-border-spacing-y: 0.75rem;
    border-spacing: var(--tw-border-spacing-x) var(--tw-border-spacing-y);
  }

  .\32xl\:flex-col {
    flex-direction: column;
  }

  .\32xl\:items-start {
    align-items: flex-start;
  }

  .\32xl\:rounded-xl {
    border-radius: 0.75rem;
  }

  .\32xl\:p-6 {
    padding: 1.5rem;
  }

  .\32xl\:p-7 {
    padding: 1.75rem;
  }

  .\32xl\:p-9 {
    padding: 2.25rem;
  }

  .\32xl\:px-12 {
    padding-left: 3rem;
    padding-right: 3rem;
  }

  .\32xl\:px-24 {
    padding-left: 6rem;
    padding-right: 6rem;
  }

  .\32xl\:py-7 {
    padding-top: 1.75rem;
    padding-bottom: 1.75rem;
  }

  .\32xl\:pb-10 {
    padding-bottom: 2.5rem;
  }

  .\32xl\:pr-10 {
    padding-right: 2.5rem;
  }

  .\32xl\:text-\[14px\] {
    font-size: 14px;
  }

  .\32xl\:text-\[16px\] {
    font-size: 16px;
  }

  .\32xl\:text-\[17px\] {
    font-size: 17px;
  }

  .\32xl\:text-\[18px\] {
    font-size: 18px;
  }

  .\32xl\:text-\[20px\] {
    font-size: 20px;
  }

  .\32xl\:text-\[43px\] {
    font-size: 43px;
  }

  .\32xl\:leading-\[55px\] {
    line-height: 55px;
  }

  .\32xl\:placeholder\:text-\[20px\]::-moz-placeholder {
    font-size: 20px;
  }

  .\32xl\:placeholder\:text-\[20px\]::placeholder {
    font-size: 20px;
  }
}