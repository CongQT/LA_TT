import { DeleteOutlined, SearchOutlined, UserOutlined } from '@ant-design/icons'
import { Breadcrumb, Button, Input, Select, Table } from 'antd'
import { PiPencilSimpleLineThin } from 'react-icons/pi'
import { useState } from 'react';
import ModalPhattu from './ModalPhattu';
import './css/style.css'
import EditPhattu from './EditPhattu';
const data=[
    {
        key:'1',
        ten:'Nguyễn Văn A',
        email:'a@gmail.com',    
        sdt:'0123456789',
        sobuoi:'11',
    },
    {
        key:'2',
        ten:'Nguyễn Văn An',
        email:'an@gmail.com',    
        sdt:'0123456987',
        sobuoi:'8',
    },
    {
        key:'3',
        ten:'Nguyễn Văn AA',
        email:'aa@gmail.com',    
        sdt:'0123456779',
        sobuoi:'11',
    },
    {
        key:'4',
        ten:'Nguyễn Văn AA',
        email:'aa@gmail.com',    
        sdt:'0123456779',
        sobuoi:'11',
    },
    {
        key:'5',
        ten:'Nguyễn Văn AA',
        email:'aa@gmail.com',    
        sdt:'0123456779',
        sobuoi:'11',
    }
]
function PhattuComponent(){
    const [open, setOpen] = useState(false);
    const [open2, setOpen2] = useState(false);
    const columns = [
        {
          title: 'Phật tử',
          dataIndex:[
            'ten'
          ],
          key: 'phattu',
          
        },
        {
          title: 'Ngày xuất gia',
          dataIndex: 'ngayxuatgia',
          key: 'ngayxuatgia',
        },
        {
          title: 'Số điện thoại',
          dataIndex: 'sdt',
          key: 'sdt',
        },
        {
          title: 'Số buổi đạo tràng đã tham gia',
          dataIndex:'sobuoi',
          key: 'sobuoi',
        },
        {
            key: 'action',
            render: (_, record) => (               
              <div className='edit'>
                <div>
                    <Button className='editbutton' onClick={() => {
                        setOpen(true);
                    }}><UserOutlined  className='iconuser'/></Button>
                    <ModalPhattu
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
                    <EditPhattu
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
                <Breadcrumb.Item>Phật tử</Breadcrumb.Item>
            </Breadcrumb>
            <div className='gsht'>Phật tử</div>
        </div>
        <div className='search'>   
            <div className='tk'>
                <div className='tim'>Tìm kiếm phật tử</div>
                <div><SearchOutlined className='iconsearch'/></div>
            </div>
            <div className='form'>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Tên</div>
                    <Input style={{width:'260px'}}/>
                </div>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Pháp danh</div>
                    <Input style={{width:'260px'}}/>
                </div>
                <div style={{marginRight:'50px'}}>
                    <div style={{marginBottom:'8px'}}>Email</div>
                    <Input style={{width:'260px'}}/>
                </div>
                <div>
                    <div style={{marginBottom:'8px'}}>Giới tính</div>
                    <Select
                        style={{
                            width: 260,
                        }}
                            options={[
                                {
                                value: 'Nam',
                                label: 'Nam',
                                },
                                {
                                value: 'Nu',
                                label: 'Nữ',
                                },         
                            ]}
                            />
                </div>
                
            </div>
            <div style={{marginTop:'8px'}}>
                    <div style={{marginBottom:'8px'}}>Trạng thái phật tử</div>
                    <Select
                        style={{
                            width: 260,
                        }}
                        options={[
                            {
                            value: 'dahoantuc',
                            label: 'Đã hoàn tục',
                            },       
                        ]}
                        />
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
            </div>
            <div className='bang'>
                <Table columns={columns} pagination={{
                position: ['none', 'none'],
              }} bordered={true} dataSource={data} />
            </div>         
        </div>
    </div>
}
export default PhattuComponent