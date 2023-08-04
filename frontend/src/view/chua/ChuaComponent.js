import { DeleteOutlined, PlusOutlined, SearchOutlined, UserOutlined } from '@ant-design/icons'
import { Breadcrumb, Button, Input, Select, Table } from 'antd'
import { useState } from 'react';
import ModalChua from './ModalChua';
import { PiPencilSimpleLineThin } from 'react-icons/pi';
import EditChua from './EditChua';
const data=[
    {
        key:'1',
        diachi:'Hà Nội',
        ngaythanhlap:'5-5-2000',    
        ten:'An',
    },
    {
        key:'1',
        diachi:'Hà Nội',
        ngaythanhlap:'5-5-2000',    
        ten:'Tâm',
    },
    {
        key:'3',
        diachi:'Hà Nội',
        ngaythanhlap:'5-5-2000',    
        ten:'Bình',
    }
]
function ChuaComponent(){
    const [open, setOpen] = useState(false);
    const [open2, setOpen2] = useState(false);
    const columns = [
        {
          title: 'Tên chùa',
          dataIndex:[
            'ten'
          ],
          key: 'ten',
          
        },
        {
          title: 'Địa chỉ',
          dataIndex: 'diachi',
          key: 'diachi',
        },
        {
          title: 'Ngày thành lập',
          dataIndex: 'ngaythanhlap',
          key: 'ngaythanhlap',
        },
        {
            key: 'action',
            render: (_, record) => (               
              <div className='edit'>
                <div>
                    <Button className='editbutton' onClick={() => {
                        setOpen(true);
                    }}><UserOutlined  className='iconuser'/></Button>
                    <ModalChua
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
                    <EditChua   
                        open={open2}   
                        onCancel={() => {
                        setOpen2(false);
                        }}
                    />  
                </div> 
                <div>
                    <Button className='editbutton' ><DeleteOutlined className='iconuser'/></Button>   
                </div>             
              </div>
            ),
          },
      ];
    return <div className='phattu'>
        <div>
            <Breadcrumb style={{ margin: '16px 0 0 0' }}>
                <Breadcrumb.Item>Home</Breadcrumb.Item>
                <Breadcrumb.Item>Chùa</Breadcrumb.Item>
            </Breadcrumb>
            <div className='gsht'>Chùa</div>
        </div>
        <div className='search'>   
            <div className='tk'>
                <div className='tim'>Tìm kiếm chùa</div>
                <div><SearchOutlined className='iconsearch2'/></div>
            </div>
            <div className='form'>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Tên</div>
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
export default ChuaComponent