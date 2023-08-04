import React from 'react';
import { createRoot } from 'react-dom/client';
import './index.css';
import './App.css'
import reportWebVitals from './reportWebVitals';
import {  Link, Outlet, RouterProvider, createBrowserRouter } from 'react-router-dom';
import DangKiPTComponent from './view/account/DangKiPTComponent';
import { Button, Menu } from 'antd';
import { MenuOutlined } from '@ant-design/icons';
import { AiFillCaretDown } from 'react-icons/ai';
import PhattuComponent from './view/PhattuComponent';
import ChuaComponent from './view/chua/ChuaComponent';
import DaoTrangComponent from './view/daotrang/DaoTrangComponent';
import DangKiComponent from './view/dangki/DangKiComponent';
import DangNhapComponent from './view/account/DangNhapComponent';
import QuenMKComponent from './view/account/QuenMKComponent';
import ResetMKComponent from './view/account/ResetMKComponent';

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
const AppLayout = () => (
  <>
  <div className="App">
  <div className="App-header">
    <div className='head'>
      <Button className='button'>
        <MenuOutlined className='icon'/>
      </Button>
      <div className='logo'><img width={120} height={120} src='https://insight.lotusacademy.edu.vn/static/img/logo_new.png'/></div>
      <div className='space'></div>
      <div className='profile'>
        <Link to={"/dangki"} element={<DangKiPTComponent/>} className='dk'>Đăng kí</Link>
        <Link to={"/dangnhap"} className='dk'>Đăng nhập</Link>
        <div><AiFillCaretDown className='icon1'/></div>
      </div>
    </div>
  </div>  
  <div className='main'>
    <div className='menu'>  
      <Menu className='item' mode="inline" items={items} />
    </div>
    <div>
      <Outlet/>
    </div>
  </div>
</div>
  </>
);
const router = createBrowserRouter([
  {
    element: <AppLayout />,
    children: [
      {
        path: "/",
        element: <PhattuComponent />,
      },
      {
        path: "/chua",
        element: <ChuaComponent />,
      },
      {
        path: "/daotrang",
        element: <DaoTrangComponent/>,
      },
      {
        path: "/dondangki",
        element: <DangKiComponent />,
      },
    ],
  },
  {
    element:<DangKiPTComponent/>,
    children:[
      {
        path:"/dangki",
      }
    ]
  },
  {
    element:<DangNhapComponent/>,
    children:[
      {
        path:"/dangnhap",
      }
    ]
  },
  {
    element:<QuenMKComponent/>,
    children:[
      {
        path:"/quenmk",
      }
    ]
  },
  {
    element:<ResetMKComponent/>,
    children:[
      {
        path:"/reset",
      }
    ]
  }
]);

createRoot(document.getElementById("root")).render(
  <RouterProvider router={router} />
);

// If you want to start measuring performance in your app, pass a function
// to log results (for example: reportWebVitals(console.log))
// or send to an analytics endpoint. Learn more: https://bit.ly/CRA-vitals
reportWebVitals();
