import { Menu } from "antd";
import { Link, Route, Routes } from "react-router-dom";
import PhattuComponent from "./PhattuComponent";
import ChuaComponent from "./chua/ChuaComponent";
import DaoTrangComponent from "./daotrang/DaoTrangComponent";
import DangKiComponent from "./dangki/DangKiComponent";
function getItem(label, key, icon, children) {
    return {
      key,
      icon,
      children,
      label,
    };
  }
const items = [
    getItem('Phật tử', '1' ,<Link to={"/"}></Link>),
    getItem('Chùa', '2', <Link to={"/chua"}></Link>),
    getItem('Đạo tràng', '3', <Link to={"/daotrang"}></Link>),
    getItem('Đơn đăng kí', '4', <Link to={"/dondangki"}></Link>),
  ];
function HomeComponent(){
    return <div className="main">
    <div className='menu'>
        <Menu className='item' mode="inline" items={items} />
        </div>
        <div>
            <Routes>
            <Route path="/" element={<PhattuComponent/>}/> 
            <Route path="/chua" element={<ChuaComponent/>}/> 
            <Route path="/daotrang" element={<DaoTrangComponent/>}/>  
            <Route path="/dondangki" element={<DangKiComponent/>}/>           
            </Routes>
        </div>
    </div>
}
export default HomeComponent;