//id传入的控件id,mode变换的熟悉值
function change(id,mode){
  document.getElementById(id).style.display=mode;
  if(mode=='block'){
   //设置下拉菜单的边框
   document.getElementById(id).style.border='1px solid #eee';
   document.getElementById(id).style.bordderTop='none';

   //设置显示下拉菜单时，鼠标划过li的效果 
   document.getElementById(id).parentNode.style.backgroundColor='#fff';
   document.getElementById(id).parentNode.style.border='1px solid #eee';
   document.getElementById(id).parentNode.style.bordderBottom='none';
  }
  else{
    //不显示下拉菜单时，鼠标划过li的效果 
    document.getElementById(id).parentNode.style.backgroundColor='';
    document.getElementById(id).parentNode.style.border='';
  }

}