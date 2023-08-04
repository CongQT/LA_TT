import { CheckCircleOutlined, DeleteOutlined, PlusCircleOutlined, PlusOutlined, SearchOutlined, UserOutlined } from '@ant-design/icons'
import { Breadcrumb, Button, Input, Select, Table } from 'antd'
import { PiPencilSimpleLineThin } from 'react-icons/pi'
import { useState } from 'react';
import ModalDaoTrang from './ModalDaoTrang';
import EditDaoTrang from './EditDaoTrang';
const data=[
    {
        key:'1',
        noidung:'Giảng đạo',
        noitochuc:'Hà Nội',    
        sothanhvien:'50',
        thoigian:'5/6/2023',
    },
    {
        key:'2',
        noidung:'Giảng đạo 2',
        noitochuc:'Hà Nội',    
        sothanhvien:'50',
        thoigian:'5/7/2023',
    },
    {
        key:'3',
        noidung:'Giảng đạo 3',
        noitochuc:'Hà Nội',    
        sothanhvien:'50',
        thoigian:'5/8/2023',
    }
]
function DaoTrangComponent(){
    const [open, setOpen] = useState(false);
    const [open2, setOpen2] = useState(false);
    const columns = [
        {
          title: 'Nội dung',
          dataIndex:[
            'noidung'
          ],
          key: 'noidung',
          
        },
        {
          title: 'Nơi tổ chức',
          dataIndex: 'noitochuc',
          key: 'noitochuc',
        },
        {
          title: 'Số thành viên tham gia',
          dataIndex: 'sothanhvien',
          key: 'sothanhvien',
        },
        {
          title: 'Thời gian tổ chức',
          dataIndex:'thoigian',
          key: 'thoigian',
        },
        {
            key: 'action',
            render: (_, record) => (               
              <div className='edit'>
                <div>
                    <Button className='editbutton' onClick={() => {
                        setOpen(true);
                    }}><UserOutlined  className='iconuser'/></Button>
                    <ModalDaoTrang
                        open={open}          
                        onCancel={() => {
                        setOpen(false);
                        }}
                    />
                </div>
                <div>
                    <Button className='editbutton' onClick={() => {
                        setOpen2(true);
                    }}><PiPencilSimpleLineThin  className='iconuser'/></Button>
                    <EditDaoTrang
                        open={open2}   
                        onCancel={() => {
                        setOpen2(false);
                        }}
                    />  
                </div>   
                <div>
                    <Button className='editbutton' ><DeleteOutlined className='iconuser'/></Button>   
                </div>  
                <div>
                    <Button className='editbutton' ><CheckCircleOutlined className='iconuser'/></Button>   
                </div>           
              </div>
            ),
          },
      ];
    return <div className='phattu'>
        <div>
            <Breadcrumb style={{ margin: '16px 0 0 0' }}>
                <Breadcrumb.Item>Home</Breadcrumb.Item>
                <Breadcrumb.Item>Đạo tràng</Breadcrumb.Item>
            </Breadcrumb>
            <div className='gsht'>Đạo tràng</div>
        </div>
        <div className='search'>   
            <div className='tk'>
                <div className='tim'>Tìm kiếm đạo tràng</div>
                <div><SearchOutlined className='iconsearch1'/></div>
            </div>
            <div className='form'>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Nội dung</div>
                    <Input style={{width:'260px'}}/>
                </div>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Nơi tổ chức</div>
                    <Input style={{width:'260px'}}/>
                </div>
            </div>
        </div>
        <div className='table'>
            <div style={{marginTop:'8px'}}>
            <Select
                    value={'Hiển thị 1-5 of 6'}
                    style={{
                        width: 150,
                        marginBottom:15
                    }}
                    options={[
                        {
                        value: '1den5',
                        label: 'Hiển thị 1-5 of 6',
                        },  
                        {
                        value: '6den10',
                        label: 'Hiển thị 6-10 of 6',
                        },
                        {
                        value: '11den15',
                        label: 'Hiển thị 11-15 of 6',
                        },      
                    ]}
                    />
                <Button className='plus'><PlusOutlined /></Button>
            </div>
            <div className='bang'>
                <Table columns={columns} pagination={{
                position: ['none', 'none'],
              }} bordered={true} dataSource={data} />
            </div>         
        </div>
    </div>
}
export default DaoTrangComponent